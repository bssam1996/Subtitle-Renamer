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
        Me.LocationButton = New System.Windows.Forms.Button()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.ItemsList = New System.Windows.Forms.ListView()
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
        Me.OptionsPanel = New System.Windows.Forms.Panel()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.automaticfillingcheckbox = New System.Windows.Forms.CheckBox()
        Me.fillascending = New System.Windows.Forms.Button()
        Me.MaximizeButton = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.EndButton = New System.Windows.Forms.PictureBox()
        Me.FilterButton = New System.Windows.Forms.PictureBox()
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
        Me.TopPanel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CopierIcon = New System.Windows.Forms.PictureBox()
        Me.FiltersPanel = New System.Windows.Forms.Panel()
        Me.ListContextMenuStrip.SuspendLayout()
        Me.OptionsPanel.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FilterContextMenuStrip.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TopPanel1.SuspendLayout()
        CType(Me.CopierIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FiltersPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LocationButton
        '
        Me.LocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LocationButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LocationButton.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LocationButton.Image = CType(resources.GetObject("LocationButton.Image"), System.Drawing.Image)
        Me.LocationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LocationButton.Location = New System.Drawing.Point(0, 34)
        Me.LocationButton.Name = "LocationButton"
        Me.LocationButton.Size = New System.Drawing.Size(197, 33)
        Me.LocationButton.TabIndex = 0
        Me.LocationButton.Text = ".."
        Me.ToolTip1.SetToolTip(Me.LocationButton, "Browse Location")
        Me.LocationButton.UseVisualStyleBackColor = True
        '
        'LocationLabel
        '
        Me.LocationLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LocationLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LocationLabel.Location = New System.Drawing.Point(313, 7)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(58, 16)
        Me.LocationLabel.TabIndex = 1
        Me.LocationLabel.Text = "Location"
        '
        'ItemsList
        '
        Me.ItemsList.AllowDrop = True
        Me.ItemsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemsList.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ItemsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.num, Me.movie, Me.vext, Me.subtitle, Me.sext, Me.number})
        Me.ItemsList.ContextMenuStrip = Me.ListContextMenuStrip
        Me.ItemsList.FullRowSelect = True
        Me.ItemsList.GridLines = True
        Me.ItemsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ItemsList.Location = New System.Drawing.Point(206, 36)
        Me.ItemsList.Name = "ItemsList"
        Me.ItemsList.Size = New System.Drawing.Size(675, 317)
        Me.ItemsList.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ItemsList, "You can rearrange subtitles using plus/minus key on keyboard")
        Me.ItemsList.UseCompatibleStateImageBehavior = False
        Me.ItemsList.View = System.Windows.Forms.View.Details
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
        Me.subtitle.Width = 223
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
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 1500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 1000
        '
        'apply
        '
        Me.apply.Enabled = False
        Me.apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.apply.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.apply.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.apply.Image = CType(resources.GetObject("apply.Image"), System.Drawing.Image)
        Me.apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.apply.Location = New System.Drawing.Point(0, 229)
        Me.apply.Name = "apply"
        Me.apply.Size = New System.Drawing.Size(197, 33)
        Me.apply.TabIndex = 10
        Me.apply.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.apply, "Start Renaming Subtitles")
        Me.apply.UseVisualStyleBackColor = True
        '
        'plus
        '
        Me.plus.BackgroundImage = CType(resources.GetObject("plus.BackgroundImage"), System.Drawing.Image)
        Me.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.plus.Enabled = False
        Me.plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plus.Location = New System.Drawing.Point(91, 176)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(50, 36)
        Me.plus.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.plus, "Add 1 (+)")
        Me.plus.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.BackgroundImage = CType(resources.GetObject("minus.BackgroundImage"), System.Drawing.Image)
        Me.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minus.Enabled = False
        Me.minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minus.Location = New System.Drawing.Point(147, 176)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(50, 36)
        Me.minus.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.minus, "Subtract 1 (-)")
        Me.minus.UseVisualStyleBackColor = True
        '
        'OptionsPanel
        '
        Me.OptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OptionsPanel.ContextMenuStrip = Me.MainContextMenuStrip
        Me.OptionsPanel.Controls.Add(Me.Label6)
        Me.OptionsPanel.Controls.Add(Me.Label5)
        Me.OptionsPanel.Controls.Add(Me.Label4)
        Me.OptionsPanel.Controls.Add(Me.Label3)
        Me.OptionsPanel.Controls.Add(Me.MenuButton)
        Me.OptionsPanel.Controls.Add(Me.LocationButton)
        Me.OptionsPanel.Controls.Add(Me.Label2)
        Me.OptionsPanel.Controls.Add(Me.automaticfillingcheckbox)
        Me.OptionsPanel.Controls.Add(Me.apply)
        Me.OptionsPanel.Controls.Add(Me.fillascending)
        Me.OptionsPanel.Controls.Add(Me.minus)
        Me.OptionsPanel.Controls.Add(Me.plus)
        Me.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.OptionsPanel.Location = New System.Drawing.Point(0, 30)
        Me.OptionsPanel.Name = "OptionsPanel"
        Me.OptionsPanel.Size = New System.Drawing.Size(200, 335)
        Me.OptionsPanel.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.OptionsPanel, "Open Folder Location")
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.AlwaysOnTopToolStripMenuItem, Me.AboutToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.MainContextMenuStrip.Name = "ContextMenuStrip1"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(171, 92)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
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
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(0, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 2)
        Me.Label6.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(0, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 2)
        Me.Label5.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(0, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 2)
        Me.Label4.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(0, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 2)
        Me.Label3.TabIndex = 13
        '
        'MenuButton
        '
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.Image = CType(resources.GetObject("MenuButton.Image"), System.Drawing.Image)
        Me.MenuButton.Location = New System.Drawing.Point(172, 3)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(25, 25)
        Me.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MenuButton.TabIndex = 2
        Me.MenuButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(17, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Video Files" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Sub Files"
        '
        'automaticfillingcheckbox
        '
        Me.automaticfillingcheckbox.AutoSize = True
        Me.automaticfillingcheckbox.Checked = True
        Me.automaticfillingcheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.automaticfillingcheckbox.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.automaticfillingcheckbox.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.automaticfillingcheckbox.Location = New System.Drawing.Point(12, 93)
        Me.automaticfillingcheckbox.Name = "automaticfillingcheckbox"
        Me.automaticfillingcheckbox.Size = New System.Drawing.Size(155, 20)
        Me.automaticfillingcheckbox.TabIndex = 6
        Me.automaticfillingcheckbox.Text = "Automatic Sub sorting"
        Me.automaticfillingcheckbox.UseVisualStyleBackColor = True
        '
        'fillascending
        '
        Me.fillascending.Enabled = False
        Me.fillascending.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fillascending.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fillascending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fillascending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fillascending.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.fillascending.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.fillascending.Image = CType(resources.GetObject("fillascending.Image"), System.Drawing.Image)
        Me.fillascending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.fillascending.Location = New System.Drawing.Point(0, 140)
        Me.fillascending.Name = "fillascending"
        Me.fillascending.Size = New System.Drawing.Size(197, 33)
        Me.fillascending.TabIndex = 7
        Me.fillascending.Text = "Fill Ascending order"
        Me.fillascending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.fillascending.UseVisualStyleBackColor = True
        '
        'MaximizeButton
        '
        Me.MaximizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeButton.Image = CType(resources.GetObject("MaximizeButton.Image"), System.Drawing.Image)
        Me.MaximizeButton.Location = New System.Drawing.Point(987, 7)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(20, 19)
        Me.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaximizeButton.TabIndex = 9
        Me.MaximizeButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.MaximizeButton, "Maximize")
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.Location = New System.Drawing.Point(961, 7)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(20, 20)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizeButton.TabIndex = 8
        Me.MinimizeButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.MinimizeButton, "Minimize")
        '
        'EndButton
        '
        Me.EndButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EndButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EndButton.Image = CType(resources.GetObject("EndButton.Image"), System.Drawing.Image)
        Me.EndButton.Location = New System.Drawing.Point(1013, 7)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(20, 20)
        Me.EndButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EndButton.TabIndex = 7
        Me.EndButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.EndButton, "End")
        '
        'FilterButton
        '
        Me.FilterButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FilterButton.Image = CType(resources.GetObject("FilterButton.Image"), System.Drawing.Image)
        Me.FilterButton.Location = New System.Drawing.Point(3, 6)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(32, 34)
        Me.FilterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FilterButton.TabIndex = 15
        Me.FilterButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.FilterButton, "Filters")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(3, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 156)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Videos Extensions"
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
        Me.CheckBox13.Location = New System.Drawing.Point(75, 109)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(60, 20)
        Me.CheckBox13.TabIndex = 11
        Me.CheckBox13.Text = ".WMV"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Checked = True
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.Location = New System.Drawing.Point(75, 91)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(54, 20)
        Me.CheckBox12.TabIndex = 10
        Me.CheckBox12.Text = ".3GP"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Checked = True
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Location = New System.Drawing.Point(6, 109)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(64, 20)
        Me.CheckBox11.TabIndex = 9
        Me.CheckBox11.Text = ".MPEG"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Location = New System.Drawing.Point(6, 91)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(58, 20)
        Me.CheckBox10.TabIndex = 8
        Me.CheckBox10.Text = ".MPG"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.Location = New System.Drawing.Point(6, 71)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(63, 20)
        Me.CheckBox9.TabIndex = 7
        Me.CheckBox9.Text = ".RMVB"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Location = New System.Drawing.Point(6, 53)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(48, 20)
        Me.CheckBox8.TabIndex = 6
        Me.CheckBox8.Text = ".RM"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.Location = New System.Drawing.Point(75, 71)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(59, 20)
        Me.CheckBox7.TabIndex = 5
        Me.CheckBox7.Text = ".MOV"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Location = New System.Drawing.Point(75, 53)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(65, 20)
        Me.CheckBox6.TabIndex = 4
        Me.CheckBox6.Text = ".WEBM"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(75, 37)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(49, 20)
        Me.CheckBox5.TabIndex = 3
        Me.CheckBox5.Text = ".FLV"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(75, 19)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(56, 20)
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
        Me.CheckBox3.Size = New System.Drawing.Size(55, 20)
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
        Me.CheckBox2.Size = New System.Drawing.Size(50, 20)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = ".AVI"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.ContextMenuStrip = Me.FilterContextMenuStrip
        Me.GroupBox2.Controls.Add(Me.CheckBox17)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox16)
        Me.GroupBox2.Controls.Add(Me.CheckBox14)
        Me.GroupBox2.Controls.Add(Me.CheckBox15)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Location = New System.Drawing.Point(3, 229)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(149, 94)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Sub ext"
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Checked = True
        Me.CheckBox17.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox17.Location = New System.Drawing.Point(6, 59)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(51, 20)
        Me.CheckBox17.TabIndex = 16
        Me.CheckBox17.Text = ".SUP"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(75, 39)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 20)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = ".ASS"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Checked = True
        Me.CheckBox16.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox16.Location = New System.Drawing.Point(75, 21)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(51, 20)
        Me.CheckBox16.TabIndex = 14
        Me.CheckBox16.Text = ".SSA"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Checked = True
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.Location = New System.Drawing.Point(6, 38)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(51, 20)
        Me.CheckBox14.TabIndex = 13
        Me.CheckBox14.Text = ".SUB"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Checked = True
        Me.CheckBox15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox15.Location = New System.Drawing.Point(6, 21)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(48, 20)
        Me.CheckBox15.TabIndex = 12
        Me.CheckBox15.Text = ".SRT"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'TopPanel1
        '
        Me.TopPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TopPanel1.ContextMenuStrip = Me.MainContextMenuStrip
        Me.TopPanel1.Controls.Add(Me.MaximizeButton)
        Me.TopPanel1.Controls.Add(Me.LocationLabel)
        Me.TopPanel1.Controls.Add(Me.MinimizeButton)
        Me.TopPanel1.Controls.Add(Me.EndButton)
        Me.TopPanel1.Controls.Add(Me.TitleLabel)
        Me.TopPanel1.Controls.Add(Me.CopierIcon)
        Me.TopPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel1.Name = "TopPanel1"
        Me.TopPanel1.Size = New System.Drawing.Size(1047, 30)
        Me.TopPanel1.TabIndex = 14
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TitleLabel.Location = New System.Drawing.Point(46, 7)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(154, 16)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "B++ -Subtitle Renamer-"
        '
        'CopierIcon
        '
        Me.CopierIcon.Image = CType(resources.GetObject("CopierIcon.Image"), System.Drawing.Image)
        Me.CopierIcon.Location = New System.Drawing.Point(12, 3)
        Me.CopierIcon.Name = "CopierIcon"
        Me.CopierIcon.Size = New System.Drawing.Size(28, 24)
        Me.CopierIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CopierIcon.TabIndex = 6
        Me.CopierIcon.TabStop = False
        '
        'FiltersPanel
        '
        Me.FiltersPanel.ContextMenuStrip = Me.MainContextMenuStrip
        Me.FiltersPanel.Controls.Add(Me.FilterButton)
        Me.FiltersPanel.Controls.Add(Me.GroupBox1)
        Me.FiltersPanel.Controls.Add(Me.GroupBox2)
        Me.FiltersPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.FiltersPanel.Location = New System.Drawing.Point(887, 30)
        Me.FiltersPanel.Name = "FiltersPanel"
        Me.FiltersPanel.Size = New System.Drawing.Size(160, 335)
        Me.FiltersPanel.TabIndex = 16
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1047, 365)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.FiltersPanel)
        Me.Controls.Add(Me.OptionsPanel)
        Me.Controls.Add(Me.ItemsList)
        Me.Controls.Add(Me.TopPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(729, 337)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subtitle Renamer"
        Me.ListContextMenuStrip.ResumeLayout(False)
        Me.OptionsPanel.ResumeLayout(False)
        Me.OptionsPanel.PerformLayout()
        Me.MainContextMenuStrip.ResumeLayout(False)
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FilterContextMenuStrip.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TopPanel1.ResumeLayout(False)
        Me.TopPanel1.PerformLayout()
        CType(Me.CopierIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FiltersPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LocationButton As Button
    Friend WithEvents LocationLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ItemsList As ListView
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
    Friend WithEvents OptionsPanel As Panel
    Friend WithEvents MenuButton As PictureBox
    Friend WithEvents TopPanel1 As Panel
    Friend WithEvents MaximizeButton As PictureBox
    Friend WithEvents MinimizeButton As PictureBox
    Friend WithEvents EndButton As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CopierIcon As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FilterButton As PictureBox
    Friend WithEvents FiltersPanel As Panel
End Class
