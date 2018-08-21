Imports System.IO
Public Class Main
    Dim vnumber As Integer = 0
    Dim subnumber As Integer = 0
    Dim bigger As Integer
    Dim locationwindows As String = ""
    Private Sub LocationButton_Click(sender As Object, e As EventArgs) Handles LocationButton.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            adding(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub
    Public Sub adding(path As String)
        Try
            ItemsList.Items.Clear()
            subnumber = 0
            vnumber = 0
            LocationLabel.Text = path
            If LocationLabel.Text.Count = 3 Then
                LocationLabel.Text = path
            Else
                LocationLabel.Text = path + "\"
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
                    ItemsList.Items.Add(q.ToString)
                    'dotPosition = dra.ToString.LastIndexOf(".")
                    'extOnly = dra.ToString.Substring(dotPosition + 1)
                    ItemsList.Items(q - 1).SubItems.Add(IO.Path.GetFileNameWithoutExtension(path + "\" + dra.ToString))
                    ItemsList.Items(q - 1).SubItems.Add(dra.Extension)
                    q += 1
                End If
            Next
            vnumber = ItemsList.Items.Count
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
            If subnumber > ItemsList.Items.Count Then
                For k = 1 To diar.Count - ItemsList.Items.Count
                    ItemsList.Items.Add(q.ToString)
                    ItemsList.Items(q - 1).SubItems.Add("")
                    ItemsList.Items(q - 1).SubItems.Add("")
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
                    ItemsList.Items(i).SubItems.Add(IO.Path.GetFileNameWithoutExtension(path + "\" + dra.ToString))
                    ItemsList.Items(i).SubItems.Add(dra.Extension)
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
                        ItemsList.Items(k).SubItems.Add("0")
                    Else
                        ItemsList.Items(k).SubItems.Add((k + 1).ToString)
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
            For Each i As ListViewItem In ItemsList.SelectedItems
                If ItemsList.SelectedItems(0).Text <> "" Then
                    vnumber -= 1
                End If
                If ItemsList.SelectedItems(0).SubItems(1).Text <> "" Then
                    subnumber -= 1
                End If
                ItemsList.Items.Remove(i)
            Next
            Label2.Text = "Total Video Files : " & vnumber & vbNewLine & "Total Subtitle files : " & subnumber
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Try
            ItemsList.Items.Clear()
            Label2.Text = "Total Video Files : 0" & vbNewLine & "Total Subtitle files : 0"
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DetailsDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsDefaultToolStripMenuItem.Click
        ItemsList.View = View.Details
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        ItemsList.View = View.List
    End Sub

    Private Sub TilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesToolStripMenuItem.Click
        ItemsList.View = View.Tile
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
    Private Sub ItemsList_DragDrop(sender As Object, e As DragEventArgs) Handles ItemsList.DragDrop
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

    Private Sub ItemsList_DragEnter(sender As Object, e As DragEventArgs) Handles ItemsList.DragEnter
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
                    ItemsList.Items(k).SubItems(5).Text = "0"
                Else
                    ItemsList.Items(k).SubItems(5).Text = k + 1
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
                    ItemsList.Items(k).SubItems.Add("0")
                Else
                    ItemsList.Items(k).SubItems.Add((k + 1).ToString)
                End If
            Next
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        Try
            If ItemsList.SelectedItems.Count > 0 Then
                For i = 0 To ItemsList.SelectedItems.Count - 1
                    If ItemsList.SelectedItems(i).SubItems(5).Text < vnumber Then
                        ItemsList.SelectedItems(i).SubItems(5).Text += 1
                    End If
                Next
            End If
            ItemsList.Focus()
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Try
            If ItemsList.SelectedItems.Count > 0 Then
                For i = 0 To ItemsList.SelectedItems.Count - 1
                    If ItemsList.SelectedItems(i).SubItems(5).Text > 1 Then
                        ItemsList.SelectedItems(i).SubItems(5).Text -= 1
                    End If
                Next
            End If
            ItemsList.Focus()
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub apply_Click(sender As Object, e As EventArgs) Handles apply.Click
        Try
            For k = 0 To subnumber - 2
                For i = k + 1 To subnumber - 1
                    If ItemsList.Items(k).SubItems(3).Text = ItemsList.Items(i).SubItems(3).Text And ItemsList.Items(k).SubItems(4).Text = ItemsList.Items(i).SubItems(4).Text Then
                        MsgBox("There is a repeated subtitle name in row " + ItemsList.Items(k).Text + " With row " + ItemsList.Items(i).Text)
                        Exit Sub
                    End If
                Next
            Next
            For k = 0 To subnumber - 1
                Dim num As Integer = Val(ItemsList.Items(k).SubItems(5).Text)
                Dim fullsub As String = ItemsList.Items(k).SubItems(3).Text + ItemsList.Items(k).SubItems(4).Text
                Dim movname As String = ItemsList.Items(num - 1).SubItems(1).Text

                If My.Computer.FileSystem.FileExists(LocationLabel.Text + movname + ItemsList.Items(k).SubItems(4).Text) = False And ItemsList.Items(k).SubItems(5).Text <> "0" Then
                    My.Computer.FileSystem.RenameFile(LocationLabel.Text + fullsub, movname + ItemsList.Items(k).SubItems(4).Text)
                End If
            Next
            If locationwindows <> "" Then
                End
            Else
                MsgBox("Done!", MsgBoxStyle.Information, "Success")
            End If

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
            If ItemsList.SelectedItems.Count > 0 Then
                For i = 0 To ItemsList.SelectedItems.Count - 1
                    ItemsList.SelectedItems(i).SubItems(5).Text = "0"
                Next
            End If
        Catch ex As Exception
            MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = Not (AlwaysOnTopToolStripMenuItem.Checked)
        AlwaysOnTopToolStripMenuItem.Checked = Not (AlwaysOnTopToolStripMenuItem.Checked)
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemsList.KeyDown
        If e.KeyCode = Keys.Add Then
            If plus.Enabled = True Then
                Try
                    If ItemsList.SelectedItems.Count > 0 Then
                        For i = 0 To ItemsList.SelectedItems.Count - 1
                            If ItemsList.SelectedItems(i).SubItems(5).Text < vnumber Then
                                ItemsList.SelectedItems(i).SubItems(5).Text += 1
                            End If
                        Next
                    End If
                    e.Handled = True
                Catch ex As Exception
                    MsgBox("There was an error occured" & vbNewLine & "Details :" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
        If e.KeyCode = Keys.Subtract Then
            Try
                If ItemsList.SelectedItems.Count > 0 Then
                    For i = 0 To ItemsList.SelectedItems.Count - 1
                        If ItemsList.SelectedItems(i).SubItems(5).Text > 1 Then
                            ItemsList.SelectedItems(i).SubItems(5).Text -= 1
                        End If
                    Next
                End If
                e.Handled = True
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
            Me.TitleLabel.Text = "B++ -Subtitle-Renamer- V" + Application.ProductVersion
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
            Try
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\Background\shell\Subtitle-Renamer") Is Nothing Or
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\shell\Subtitle-Renamer") Is Nothing Or
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\*\shell\Subtitle-Renamer") Is Nothing Then
                    AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Text = "Add Sub-Ren to right click context menu of windows"
                Else
                    AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Checked = True
                    AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Text = "Remove Sub-Ren to right click context menu of windows"
                End If
            Catch
            End Try
            If My.Application.CommandLineArgs.Count > 0 Then
                For i As Integer = 0 To My.Application.CommandLineArgs.Count - 1
                    locationwindows = locationwindows + My.Application.CommandLineArgs(i).ToString + " "
                Next
                locationwindows = locationwindows.Trim
                adding(locationwindows)
                apply.PerformClick()

            Else
                MenuButton_Click(MenuButton, e)
                FilterButton_Click(FilterButton, e)
            End If

        Catch
        End Try

    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        If OptionsPanel.Width = 200 Then
            While OptionsPanel.Width > 50
                OptionsPanel.Width -= 5
                MenuButton.Location = New Point(MenuButton.Location.X - 5, MenuButton.Location.Y)
                ItemsList.Location = New Point(ItemsList.Location.X - 5, ItemsList.Location.Y)
                ItemsList.Width = ItemsList.Width + 5
                System.Threading.Thread.Sleep(1)
            End While
            movie.Width += 75
            subtitle.Width += 75
        Else
            While OptionsPanel.Width < 200
                OptionsPanel.Width += 5
                MenuButton.Location = New Point(MenuButton.Location.X + 5, MenuButton.Location.Y)
                ItemsList.Location = New Point(ItemsList.Location.X + 5, ItemsList.Location.Y)
                ItemsList.Width = ItemsList.Width - 5
                System.Threading.Thread.Sleep(1)
            End While
            movie.Width -= 75
            subtitle.Width -= 75
        End If
    End Sub

    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        If FiltersPanel.Width = 160 Then
            While FiltersPanel.Width > 44
                FiltersPanel.Width -= 4
                FilterButton.Location = New Point(FilterButton.Location.X + 4, FilterButton.Location.Y)
                ItemsList.Width = ItemsList.Width + 4
                System.Threading.Thread.Sleep(1)
            End While
            movie.Width += 58
            subtitle.Width += 58
        Else
            While FiltersPanel.Width < 160
                FiltersPanel.Width += 4
                FilterButton.Location = New Point(FilterButton.Location.X - 4, FilterButton.Location.Y)
                ItemsList.Width = ItemsList.Width - 4
                System.Threading.Thread.Sleep(1)
            End While
            movie.Width -= 58
            subtitle.Width -= 58
        End If
    End Sub
    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        End
    End Sub

    Private Sub MaximizeButton_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub TopPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel1.MouseDown, TitleLabel.MouseDown, LocationLabel.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TopPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel1.MouseMove, TitleLabel.MouseMove, LocationLabel.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TopPanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel1.MouseUp, TitleLabel.MouseUp, LocationLabel.MouseUp
        drag = False
    End Sub

    Private Sub CopierIcon_Click(sender As Object, e As EventArgs) Handles CopierIcon.Click
        About.ShowDialog()
    End Sub

    Private Sub AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Click
        Try
            If AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Text.Contains("Add") Then
                'For Windows explorer
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\", True).CreateSubKey("directory")
                End If
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\Background") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\", True).CreateSubKey("Background")
                End If
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\Background\shell") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\Background\", True).CreateSubKey("shell")
                End If
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\Background\shell\Subtitle-Renamer") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\Background\shell\", True).CreateSubKey("Subtitle-Renamer")
                End If
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\Background\shell\Subtitle-Renamer\command") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\Background\shell\Subtitle-Renamer\", True).CreateSubKey("command")
                End If
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\directory\Background\shell\Subtitle-Renamer", "", "Quick Subtitle-Renamer")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\directory\Background\shell\Subtitle-Renamer", "Icon", Application.ExecutablePath)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\directory\Background\shell\Subtitle-Renamer\command", "", Application.ExecutablePath + " %v")
                'For folders
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\shell") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\", True).CreateSubKey("shell")
                End If
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\shell\Subtitle-Renamer") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\shell\", True).CreateSubKey("Subtitle-Renamer")
                End If
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\shell\Subtitle-Renamer\command") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\directory\shell\Subtitle-Renamer\", True).CreateSubKey("command")
                End If
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\directory\shell\Subtitle-Renamer", "", "Quick Subtitle-Renamer")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\directory\shell\Subtitle-Renamer", "Icon", Application.ExecutablePath)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\directory\shell\Subtitle-Renamer\command", "", Application.ExecutablePath + " %v")
                'For Files
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\*\shell") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\*\", True).CreateSubKey("shell")
                End If
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\*\shell\Subtitle-Renamer") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\*\shell\", True).CreateSubKey("Subtitle-Renamer")
                End If
                If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\*\shell\Subtitle-Renamer\command") Is Nothing Then
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\*\shell\Subtitle-Renamer\", True).CreateSubKey("command")
                End If
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\*\shell\Subtitle-Renamer", "", "Quick Subtitle-Renamer")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\*\shell\Subtitle-Renamer", "Icon", Application.ExecutablePath)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\*\shell\Subtitle-Renamer\command", "", Application.ExecutablePath + " %v")
                AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Checked = True
                AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Text = "Remove Sub-Ren to right click context menu of windows"
            Else
                Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree("SOFTWARE\Classes\*\shell\Subtitle-Renamer")
                Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree("SOFTWARE\Classes\directory\shell\Subtitle-Renamer")
                Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree("SOFTWARE\Classes\directory\Background\shell\Subtitle-Renamer")
                AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Checked = False
                AddSubRenToRightClickContextMenuOfWindowsToolStripMenuItem.Text = "Add Sub-Ren to right click context menu of windows"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    System.Threading.Thread.Sleep(2000)
    '    MsgBox(System.Diagnostics.Process.GetCurrentProcess.MainWindowTitle)
    'End Sub
End Class
