namespace LSRVersionManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("LEGO Stunt Rally", 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("LEGO Stunt Rally Japanese DEMO", 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("LEGO Stunt Rally English DEMO", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gameVersionLabel = new System.Windows.Forms.Label();
            this.launchBtn = new System.Windows.Forms.Button();
            this.gameModifiedLabel = new System.Windows.Forms.Label();
            this.keepLauncherCheck = new System.Windows.Forms.CheckBox();
            this.customArgsBox = new System.Windows.Forms.TextBox();
            this.customArgsLabel = new System.Windows.Forms.Label();
            this.launchArgsGroupBox = new System.Windows.Forms.GroupBox();
            this.versionsListView = new System.Windows.Forms.ListView();
            this.versionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.versionsMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.versionsMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.thumbnailImages = new System.Windows.Forms.ImageList(this.components);
            this.versionGroupBox = new System.Windows.Forms.GroupBox();
            this.metadataGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameRegionLabel = new System.Windows.Forms.Label();
            this.versionAddBtn = new System.Windows.Forms.Button();
            this.versionDelBtn = new System.Windows.Forms.Button();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.launchArgsEditor = new LSRVersionManager.EnumEditor();
            this.notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyMenuName = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.notifyMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.launchArgsGroupBox.SuspendLayout();
            this.versionsContextMenu.SuspendLayout();
            this.versionGroupBox.SuspendLayout();
            this.metadataGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.notifyIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameVersionLabel
            // 
            this.gameVersionLabel.AutoSize = true;
            this.gameVersionLabel.Location = new System.Drawing.Point(3, 0);
            this.gameVersionLabel.Name = "gameVersionLabel";
            this.gameVersionLabel.Size = new System.Drawing.Size(81, 13);
            this.gameVersionLabel.TabIndex = 0;
            this.gameVersionLabel.Text = "Version: 0.0.0.0";
            // 
            // launchBtn
            // 
            this.launchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchBtn.Location = new System.Drawing.Point(12, 363);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(193, 23);
            this.launchBtn.TabIndex = 1;
            this.launchBtn.Text = "Launch Game";
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // gameModifiedLabel
            // 
            this.gameModifiedLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.gameModifiedLabel, 2);
            this.gameModifiedLabel.Location = new System.Drawing.Point(3, 22);
            this.gameModifiedLabel.Name = "gameModifiedLabel";
            this.gameModifiedLabel.Size = new System.Drawing.Size(53, 13);
            this.gameModifiedLabel.TabIndex = 2;
            this.gameModifiedLabel.Text = "Modified: ";
            // 
            // keepLauncherCheck
            // 
            this.keepLauncherCheck.AutoSize = true;
            this.keepLauncherCheck.Checked = true;
            this.keepLauncherCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepLauncherCheck.Location = new System.Drawing.Point(211, 367);
            this.keepLauncherCheck.Name = "keepLauncherCheck";
            this.keepLauncherCheck.Size = new System.Drawing.Size(211, 17);
            this.keepLauncherCheck.TabIndex = 3;
            this.keepLauncherCheck.Text = "Keep launcher open in the background";
            this.keepLauncherCheck.UseVisualStyleBackColor = true;
            // 
            // customArgsBox
            // 
            this.customArgsBox.Location = new System.Drawing.Point(119, 318);
            this.customArgsBox.Name = "customArgsBox";
            this.customArgsBox.Size = new System.Drawing.Size(303, 20);
            this.customArgsBox.TabIndex = 4;
            this.customArgsBox.TextChanged += new System.EventHandler(this.customArgsBox_TextChanged);
            // 
            // customArgsLabel
            // 
            this.customArgsLabel.AutoSize = true;
            this.customArgsLabel.Location = new System.Drawing.Point(12, 321);
            this.customArgsLabel.Name = "customArgsLabel";
            this.customArgsLabel.Size = new System.Drawing.Size(101, 13);
            this.customArgsLabel.TabIndex = 5;
            this.customArgsLabel.Text = "Custom Arguments: ";
            // 
            // launchArgsGroupBox
            // 
            this.launchArgsGroupBox.Controls.Add(this.launchArgsEditor);
            this.launchArgsGroupBox.Location = new System.Drawing.Point(290, 12);
            this.launchArgsGroupBox.Name = "launchArgsGroupBox";
            this.launchArgsGroupBox.Size = new System.Drawing.Size(132, 224);
            this.launchArgsGroupBox.TabIndex = 7;
            this.launchArgsGroupBox.TabStop = false;
            this.launchArgsGroupBox.Text = "Launch Arguments";
            // 
            // versionsListView
            // 
            this.versionsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.versionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.versionHeader});
            this.versionsListView.ContextMenuStrip = this.versionsContextMenu;
            this.versionsListView.GridLines = true;
            this.versionsListView.HideSelection = false;
            listViewItem4.ToolTipText = "C:\\LSR";
            this.versionsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.versionsListView.LargeImageList = this.thumbnailImages;
            this.versionsListView.Location = new System.Drawing.Point(6, 19);
            this.versionsListView.MultiSelect = false;
            this.versionsListView.Name = "versionsListView";
            this.versionsListView.Size = new System.Drawing.Size(260, 199);
            this.versionsListView.SmallImageList = this.thumbnailImages;
            this.versionsListView.TabIndex = 11;
            this.versionsListView.UseCompatibleStateImageBehavior = false;
            this.versionsListView.View = System.Windows.Forms.View.Tile;
            this.versionsListView.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // versionHeader
            // 
            this.versionHeader.Text = "Versions";
            // 
            // versionsContextMenu
            // 
            this.versionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionsMenuItemAdd,
            this.versionsMenuItemDel});
            this.versionsContextMenu.Name = "versionsContextMenu";
            this.versionsContextMenu.Size = new System.Drawing.Size(180, 48);
            this.versionsContextMenu.Text = "gamer";
            // 
            // versionsMenuItemAdd
            // 
            this.versionsMenuItemAdd.Name = "versionsMenuItemAdd";
            this.versionsMenuItemAdd.ShortcutKeyDisplayString = "";
            this.versionsMenuItemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.versionsMenuItemAdd.Size = new System.Drawing.Size(179, 22);
            this.versionsMenuItemAdd.Text = "Add version";
            this.versionsMenuItemAdd.Click += new System.EventHandler(this.versionsMenuItemAdd_Click);
            // 
            // versionsMenuItemDel
            // 
            this.versionsMenuItemDel.Name = "versionsMenuItemDel";
            this.versionsMenuItemDel.Size = new System.Drawing.Size(179, 22);
            this.versionsMenuItemDel.Text = "Remove version";
            this.versionsMenuItemDel.Click += new System.EventHandler(this.versionsMenuItemDel_Click);
            // 
            // thumbnailImages
            // 
            this.thumbnailImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("thumbnailImages.ImageStream")));
            this.thumbnailImages.TransparentColor = System.Drawing.Color.Transparent;
            this.thumbnailImages.Images.SetKeyName(0, "LegoLogo");
            // 
            // versionGroupBox
            // 
            this.versionGroupBox.Controls.Add(this.versionsListView);
            this.versionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.versionGroupBox.Name = "versionGroupBox";
            this.versionGroupBox.Size = new System.Drawing.Size(272, 224);
            this.versionGroupBox.TabIndex = 12;
            this.versionGroupBox.TabStop = false;
            this.versionGroupBox.Text = "Version";
            // 
            // metadataGroupBox
            // 
            this.metadataGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.metadataGroupBox.Location = new System.Drawing.Point(12, 242);
            this.metadataGroupBox.Name = "metadataGroupBox";
            this.metadataGroupBox.Size = new System.Drawing.Size(272, 70);
            this.metadataGroupBox.TabIndex = 13;
            this.metadataGroupBox.TabStop = false;
            this.metadataGroupBox.Text = "Metadata";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gameVersionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameRegionLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameModifiedLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 44);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gameRegionLabel
            // 
            this.gameRegionLabel.AutoSize = true;
            this.gameRegionLabel.Location = new System.Drawing.Point(132, 0);
            this.gameRegionLabel.Name = "gameRegionLabel";
            this.gameRegionLabel.Size = new System.Drawing.Size(65, 13);
            this.gameRegionLabel.TabIndex = 3;
            this.gameRegionLabel.Text = "Region: ???";
            // 
            // versionAddBtn
            // 
            this.versionAddBtn.Location = new System.Drawing.Point(6, 19);
            this.versionAddBtn.Name = "versionAddBtn";
            this.versionAddBtn.Size = new System.Drawing.Size(120, 21);
            this.versionAddBtn.TabIndex = 15;
            this.versionAddBtn.Text = "Add Version";
            this.versionAddBtn.UseVisualStyleBackColor = true;
            this.versionAddBtn.Click += new System.EventHandler(this.versionAddBtn_Click);
            // 
            // versionDelBtn
            // 
            this.versionDelBtn.Location = new System.Drawing.Point(6, 42);
            this.versionDelBtn.Name = "versionDelBtn";
            this.versionDelBtn.Size = new System.Drawing.Size(120, 21);
            this.versionDelBtn.TabIndex = 16;
            this.versionDelBtn.Text = "Remove Version";
            this.versionDelBtn.UseVisualStyleBackColor = true;
            this.versionDelBtn.Click += new System.EventHandler(this.versionDelBtn_Click);
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.versionAddBtn);
            this.actionsGroupBox.Controls.Add(this.versionDelBtn);
            this.actionsGroupBox.Location = new System.Drawing.Point(290, 242);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(132, 70);
            this.actionsGroupBox.TabIndex = 17;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Actions";
            // 
            // statusStrip
            // 
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(434, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 18;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(215, 17);
            this.toolStripStatusLabel1.Text = "LSR Version Manager by OpenLSR Team";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LSR Version Manager";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // launchArgsEditor
            // 
            this.launchArgsEditor.CheckOnClick = true;
            this.launchArgsEditor.FormattingEnabled = true;
            this.launchArgsEditor.Items.AddRange(new object[] {
            LSRVersionManager.GameArgs.NoIntroVideo,
            LSRVersionManager.GameArgs.AllAI,
            LSRVersionManager.GameArgs.CDIn,
            LSRVersionManager.GameArgs.DebugInfo,
            LSRVersionManager.GameArgs.Files,
            LSRVersionManager.GameArgs.Freeform,
            LSRVersionManager.GameArgs.IGTest,
            LSRVersionManager.GameArgs.Load_Text,
            LSRVersionManager.GameArgs.NoRes,
            LSRVersionManager.GameArgs.Res_Files,
            LSRVersionManager.GameArgs.Windowed,
            LSRVersionManager.GameArgs.XAFToXBF});
            this.launchArgsEditor.Location = new System.Drawing.Point(6, 19);
            this.launchArgsEditor.Name = "launchArgsEditor";
            this.launchArgsEditor.Size = new System.Drawing.Size(120, 199);
            this.launchArgsEditor.TabIndex = 6;
            this.launchArgsEditor.Value = LSRVersionManager.GameArgs.None;
            this.launchArgsEditor.SelectedIndexChanged += new System.EventHandler(this.enumEditor1_SelectedIndexChanged);
            // 
            // notifyIconContextMenu
            // 
            this.notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyMenuName,
            this.notifyMenuVersion,
            this.notifyMenuSeparator,
            this.notifyMenuExit});
            this.notifyIconContextMenu.Name = "notifyIconContextMenu";
            this.notifyIconContextMenu.Size = new System.Drawing.Size(185, 76);
            // 
            // notifyMenuName
            // 
            this.notifyMenuName.Enabled = false;
            this.notifyMenuName.Name = "notifyMenuName";
            this.notifyMenuName.Size = new System.Drawing.Size(184, 22);
            this.notifyMenuName.Text = "LSR Version Manager";
            // 
            // notifyMenuVersion
            // 
            this.notifyMenuVersion.Enabled = false;
            this.notifyMenuVersion.Name = "notifyMenuVersion";
            this.notifyMenuVersion.Size = new System.Drawing.Size(184, 22);
            this.notifyMenuVersion.Text = "Version 0.0.0.0";
            // 
            // notifyMenuSeparator
            // 
            this.notifyMenuSeparator.Name = "notifyMenuSeparator";
            this.notifyMenuSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // notifyMenuExit
            // 
            this.notifyMenuExit.Name = "notifyMenuExit";
            this.notifyMenuExit.Size = new System.Drawing.Size(184, 22);
            this.notifyMenuExit.Text = "Close Launcher";
            this.notifyMenuExit.Click += new System.EventHandler(this.notifyMenuExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.metadataGroupBox);
            this.Controls.Add(this.versionGroupBox);
            this.Controls.Add(this.launchArgsGroupBox);
            this.Controls.Add(this.customArgsLabel);
            this.Controls.Add(this.customArgsBox);
            this.Controls.Add(this.keepLauncherCheck);
            this.Controls.Add(this.launchBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LSR Version Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.launchArgsGroupBox.ResumeLayout(false);
            this.versionsContextMenu.ResumeLayout(false);
            this.versionGroupBox.ResumeLayout(false);
            this.metadataGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.actionsGroupBox.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.notifyIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameVersionLabel;
        private System.Windows.Forms.Button launchBtn;
        private System.Windows.Forms.Label gameModifiedLabel;
        private System.Windows.Forms.CheckBox keepLauncherCheck;
        private System.Windows.Forms.TextBox customArgsBox;
        private System.Windows.Forms.Label customArgsLabel;
        private EnumEditor launchArgsEditor;
        private System.Windows.Forms.GroupBox launchArgsGroupBox;
        private System.Windows.Forms.ListView versionsListView;
        private System.Windows.Forms.ImageList thumbnailImages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox versionGroupBox;
        private System.Windows.Forms.GroupBox metadataGroupBox;
        private System.Windows.Forms.Label gameRegionLabel;
        private System.Windows.Forms.ColumnHeader versionHeader;
        private System.Windows.Forms.ContextMenuStrip versionsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem versionsMenuItemAdd;
        private System.Windows.Forms.Button versionAddBtn;
        private System.Windows.Forms.Button versionDelBtn;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.ToolStripMenuItem versionsMenuItemDel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuName;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuVersion;
        private System.Windows.Forms.ToolStripSeparator notifyMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuExit;
    }
}

