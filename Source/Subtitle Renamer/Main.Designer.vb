<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.num = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.movie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vext = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subtitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sext = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTheViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetFillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcludeInChangingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.apply = New System.Windows.Forms.Button()
        Me.plus = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.automaticfillingcheckbox = New System.Windows.Forms.CheckBox()
        Me.fillascending = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FilterContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckUncheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListContextMenuStrip.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FilterContextMenuStrip.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(150, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = ".."
        Me.ToolTip1.SetToolTip(Me.Button1, "Browse Location")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Location"
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.num, Me.movie, Me.vext, Me.subtitle, Me.sext, Me.number})
        Me.ListView1.ContextMenuStrip = Me.ListContextMenuStrip
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(12, 8)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(689, 193)
        Me.ListView1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ListView1, "You can rearrange subtitles using plus/minus key on keyboard")
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'num
        '
        Me.num.Text = "#"
        Me.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num.Width = 28
        '
        'movie
        '
        Me.movie.Text = "Video"
        Me.movie.Width = 223
        '
        'vext
        '
        Me.vext.Text = "Ext"
        '
        'subtitle
        '
        Me.subtitle.Text = "Subtitle"
        Me.subtitle.Width = 220
        '
        'sext
        '
        Me.sext.Text = "Ext"
        Me.sext.Width = 57
        '
        'number
        '
        Me.number.Text = "Sub to #Video"
        Me.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.number.Width = 78
        '
        'ListContextMenuStrip
        '
        Me.ListContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteThisItemToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.ChangeTheViewToolStripMenuItem, Me.ResetFillingToolStripMenuItem, Me.ExcludeInChangingToolStripMenuItem})
        Me.ListContextMenuStrip.Name = "ContextMenuStrip2"
        Me.ListContextMenuStrip.Size = New System.Drawing.Size(183, 114)
        '
        'DeleteThisItemToolStripMenuItem
        '
        Me.DeleteThisItemToolStripMenuItem.Image = CType(resources.GetObject("DeleteThisItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteThisItemToolStripMenuItem.Name = "DeleteThisItemToolStripMenuItem"
        Me.DeleteThisItemToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DeleteThisItemToolStripMenuItem.Text = "Delete item\items"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Image = CType(resources.GetObject("ClearAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'ChangeTheViewToolStripMenuItem
        '
        Me.ChangeTheViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsDefaultToolStripMenuItem, Me.ListToolStripMenuItem, Me.TilesToolStripMenuItem})
        Me.ChangeTheViewToolStripMenuItem.Image = CType(resources.GetObject("ChangeTheViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeTheViewToolStripMenuItem.Name = "ChangeTheViewToolStripMenuItem"
        Me.ChangeTheViewToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ChangeTheViewToolStripMenuItem.Text = "Change the view"
        '
        'DetailsDefaultToolStripMenuItem
        '
        Me.DetailsDefaultToolStripMenuItem.Name = "DetailsDefaultToolStripMenuItem"
        Me.DetailsDefaultToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DetailsDefaultToolStripMenuItem.Text = "Details (Default)"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'TilesToolStripMenuItem
        '
        Me.TilesToolStripMenuItem.Name = "TilesToolStripMenuItem"
        Me.TilesToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TilesToolStripMenuItem.Text = "Tile"
        '
        'ResetFillingToolStripMenuItem
        '
        Me.ResetFillingToolStripMenuItem.Enabled = False
        Me.ResetFillingToolStripMenuItem.Image = CType(resources.GetObject("ResetFillingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetFillingToolStripMenuItem.Name = "ResetFillingToolStripMenuItem"
        Me.ResetFillingToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ResetFillingToolStripMenuItem.Text = "Reset Filling"
        '
        'ExcludeInChangingToolStripMenuItem
        '
        Me.ExcludeInChangingToolStripMenuItem.Image = CType(resources.GetObject("ExcludeInChangingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcludeInChangingToolStripMenuItem.Name = "ExcludeInChangingToolStripMenuItem"
        Me.ExcludeInChangingToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExcludeInChangingToolStripMenuItem.Text = "Exclude in Changing"
        Me.ExcludeInChangingToolStripMenuItem.ToolTipText = "Make sub number = 0 to exclude it from changing its name"
        '
        'apply
        '
        Me.apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.apply.Enabled = False
        Me.apply.Location = New System.Drawing.Point(139, 280)
        Me.apply.Name = "apply"
        Me.apply.Size = New System.Drawing.Size(62, 33)
        Me.apply.TabIndex = 10
        Me.apply.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.apply, "Start Renaming Subtitles")
        Me.apply.UseVisualStyleBackColor = True
        '
        'plus
        '
        Me.plus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.plus.BackgroundImage = CType(resources.GetObject("plus.BackgroundImage"), System.Drawing.Image)
        Me.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.plus.Enabled = False
        Me.plus.Location = New System.Drawing.Point(124, 253)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(41, 23)
        Me.plus.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.plus, "Add 1")
        Me.plus.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.minus.BackgroundImage = CType(resources.GetObject("minus.BackgroundImage"), System.Drawing.Image)
        Me.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minus.Enabled = False
        Me.minus.Location = New System.Drawing.Point(171, 253)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(41, 23)
        Me.minus.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.minus, "Subtract 1")
        Me.minus.UseVisualStyleBackColor = True
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.AlwaysOnTopToolStripMenuItem, Me.AboutToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.MainContextMenuStrip.Name = "ContextMenuStrip1"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(171, 92)
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always On Top"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Image = CType(resources.GetObject("EndToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Video Files" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Sub Files"
        '
        'automaticfillingcheckbox
        '
        Me.automaticfillingcheckbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.automaticfillingcheckbox.AutoSize = True
        Me.automaticfillingcheckbox.Checked = True
        Me.automaticfillingcheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.automaticfillingcheckbox.Location = New System.Drawing.Point(13, 217)
        Me.automaticfillingcheckbox.Name = "automaticfillingcheckbox"
        Me.automaticfillingcheckbox.Size = New System.Drawing.Size(131, 17)
        Me.automaticfillingcheckbox.TabIndex = 6
        Me.automaticfillingcheckbox.Text = "Automatic Sub sorting"
        Me.automaticfillingcheckbox.UseVisualStyleBackColor = True
        '
        'fillascending
        '
        Me.fillascending.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fillascending.Enabled = False
        Me.fillascending.Location = New System.Drawing.Point(8, 253)
        Me.fillascending.Name = "fillascending"
        Me.fillascending.Size = New System.Drawing.Size(110, 23)
        Me.fillascending.TabIndex = 7
        Me.fillascending.Text = "Fill Ascending order"
        Me.fillascending.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.ContextMenuStrip = Me.FilterContextMenuStrip
        Me.GroupBox1.Controls.Add(Me.CheckBox13)
        Me.GroupBox1.Controls.Add(Me.CheckBox12)
        Me.GroupBox1.Controls.Add(Me.CheckBox11)
        Me.GroupBox1.Controls.Add(Me.CheckBox10)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(218, 253)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 60)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter adding extensions for videos"
        '
        'FilterContextMenuStrip
        '
        Me.FilterContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckUncheckToolStripMenuItem})
        Me.FilterContextMenuStrip.Name = "ContextMenuStrip3"
        Me.FilterContextMenuStrip.Size = New System.Drawing.Size(176, 26)
        '
        'CheckUncheckToolStripMenuItem
        '
        Me.CheckUncheckToolStripMenuItem.Image = CType(resources.GetObject("CheckUncheckToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckUncheckToolStripMenuItem.Name = "CheckUncheckToolStripMenuItem"
        Me.CheckUncheckToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CheckUncheckToolStripMenuItem.Text = "Check\Uncheck All"
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Checked = True
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.Location = New System.Drawing.Point(301, 37)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox13.TabIndex = 11
        Me.CheckBox13.Text = ".WMV"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Checked = True
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.Location = New System.Drawing.Point(301, 19)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox12.TabIndex = 10
        Me.CheckBox12.Text = ".3GP"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Checked = True
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Location = New System.Drawing.Point(238, 37)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox11.TabIndex = 9
        Me.CheckBox11.Text = ".MPEG"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Location = New System.Drawing.Point(238, 19)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox10.TabIndex = 8
        Me.CheckBox10.Text = ".MPG"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.Location = New System.Drawing.Point(114, 37)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox9.TabIndex = 7
        Me.CheckBox9.Text = ".RMVB"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Location = New System.Drawing.Point(114, 19)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox8.TabIndex = 6
        Me.CheckBox8.Text = ".RM"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.Location = New System.Drawing.Point(172, 37)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox7.TabIndex = 5
        Me.CheckBox7.Text = ".MOV"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Location = New System.Drawing.Point(172, 19)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox6.TabIndex = 4
        Me.CheckBox6.Text = ".WEBM"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(58, 37)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox5.TabIndex = 3
        Me.CheckBox5.Text = ".FLV"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(58, 19)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox4.TabIndex = 2
        Me.CheckBox4.Text = ".MKV"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(6, 37)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.Text = ".MP4"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = ".AVI"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.ContextMenuStrip = Me.FilterContextMenuStrip
        Me.GroupBox2.Controls.Add(Me.CheckBox17)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox16)
        Me.GroupBox2.Controls.Add(Me.CheckBox14)
        Me.GroupBox2.Controls.Add(Me.CheckBox15)
        Me.GroupBox2.Location = New System.Drawing.Point(587, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 83)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Sub ext"
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Checked = True
        Me.CheckBox17.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox17.Location = New System.Drawing.Point(6, 57)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox17.TabIndex = 16
        Me.CheckBox17.Text = ".SUP"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(61, 37)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = ".ASS"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Checked = True
        Me.CheckBox16.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox16.Location = New System.Drawing.Point(61, 19)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox16.TabIndex = 14
        Me.CheckBox16.Text = ".SSA"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Checked = True
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.Location = New System.Drawing.Point(6, 36)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox14.TabIndex = 13
        Me.CheckBox14.Text = ".SUB"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Checked = True
        Me.CheckBox15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox15.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox15.TabIndex = 12
        Me.CheckBox15.Text = ".SRT"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(713, 316)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.apply)
        Me.Controls.Add(Me.minus)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.fillascending)
        Me.Controls.Add(Me.automaticfillingcheckbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(729, 337)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subtitle Renamer"
        Me.ListContextMenuStrip.ResumeLayout(False)
        Me.MainContextMenuStrip.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FilterContextMenuStrip.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ListView1 As ListView
    Friend WithEvents movie As ColumnHeader
    Friend WithEvents subtitle As ColumnHeader
    Friend WithEvents number As ColumnHeader
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListContextMenuStrip As ContextMenuStrip
    Friend WithEvents DeleteThisItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeTheViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailsDefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents num As ColumnHeader
    Friend WithEvents automaticfillingcheckbox As CheckBox
    Friend WithEvents vext As ColumnHeader
    Friend WithEvents sext As ColumnHeader
    Friend WithEvents fillascending As Button
    Friend WithEvents ResetFillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents plus As Button
    Friend WithEvents minus As Button
    Friend WithEvents apply As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents FilterContextMenuStrip As ContextMenuStrip
    Friend WithEvents CheckUncheckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents ExcludeInChangingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
End Class
