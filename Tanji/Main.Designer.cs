namespace Tanji
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TanjiStrip = new System.Windows.Forms.StatusStrip();
            this.VersionTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.SchedulesTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExtensionsActiveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiInfoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.EExtensionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EUninstallBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EExtensionsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.EInstallExtensionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseExtensionDlg = new System.Windows.Forms.OpenFileDialog();
            this.TanjiTip = new System.Windows.Forms.ToolTip(this.components);
            this.ISBurstTxt = new System.Windows.Forms.NumericUpDown();
            this.ISIntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.ISDescriptionTxt = new System.Windows.Forms.TextBox();
            this.ISSchedulesLstVw = new Sulakore.Components.SKoreScheduler();
            this.ISPacketCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBurstCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISIntervalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICConstructMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ICCopyPacketBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICTransferToBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICSchedulerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICPrimitiveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICTransferSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ICInjectionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.IPacketTxt = new System.Windows.Forms.TextBox();
            this.ISendToClientBtn = new Sulakore.Components.SKoreButton();
            this.ISendToServerBtn = new Sulakore.Components.SKoreButton();
            this.IInjectionTabs = new Sulakore.Components.SKoreTabControl();
            this.IConstructerTab = new System.Windows.Forms.TabPage();
            this.ICChunksRightGlowPnl = new System.Windows.Forms.Panel();
            this.ICChunksLeftGlowPnl = new System.Windows.Forms.Panel();
            this.ICChunkCountLbl = new System.Windows.Forms.Label();
            this.ICCountTxt = new System.Windows.Forms.NumericUpDown();
            this.ICCountLbl = new System.Windows.Forms.Label();
            this.ICRemoveBtn = new Sulakore.Components.SKoreButton();
            this.ICMoveDownBtn = new Sulakore.Components.SKoreButton();
            this.ICMoveUpBtn = new Sulakore.Components.SKoreButton();
            this.ICClearBtn = new Sulakore.Components.SKoreButton();
            this.ICAppendBooleanBtn = new Sulakore.Components.SKoreButton();
            this.ICAppendStringBtn = new Sulakore.Components.SKoreButton();
            this.ICAppendIntegerBtn = new Sulakore.Components.SKoreButton();
            this.ICHeaderLbl = new System.Windows.Forms.Label();
            this.ICHeaderTxt = new System.Windows.Forms.TextBox();
            this.ICValueLbl = new System.Windows.Forms.Label();
            this.ICValueTxt = new System.Windows.Forms.TextBox();
            this.ICConstructerLstVw = new Sulakore.Components.SKoreConstructer();
            this.ICTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICEncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISchedulerTab = new System.Windows.Forms.TabPage();
            this.ISClearBtn = new Sulakore.Components.SKoreButton();
            this.ISAutoStartChckbx = new System.Windows.Forms.CheckBox();
            this.ISBurstLbl = new System.Windows.Forms.Label();
            this.ISStopAllBtn = new Sulakore.Components.SKoreButton();
            this.ISIntervalLbl = new System.Windows.Forms.Label();
            this.ISDestinationLbl = new System.Windows.Forms.Label();
            this.ISDestinationTxt = new System.Windows.Forms.ComboBox();
            this.ISPacketLbl = new System.Windows.Forms.Label();
            this.ISPacketTxt = new System.Windows.Forms.TextBox();
            this.ISDescriptionLbl = new System.Windows.Forms.Label();
            this.ISStartAllBtn = new Sulakore.Components.SKoreButton();
            this.ISRemoveBtn = new Sulakore.Components.SKoreButton();
            this.ISCreateBtn = new Sulakore.Components.SKoreButton();
            this.IPrimitiveTab = new System.Windows.Forms.TabPage();
            this.IPIsCorruptedLbl = new System.Windows.Forms.Label();
            this.IPPacketInfoLbl = new System.Windows.Forms.Label();
            this.IPPacketTxt = new System.Windows.Forms.TextBox();
            this.ITriggersTab = new System.Windows.Forms.TabPage();
            this.IFiltersTab = new System.Windows.Forms.TabPage();
            this.IFFilterTabs = new Sulakore.Components.SKoreTabControl();
            this.IFReplaceTab = new System.Windows.Forms.TabPage();
            this.IFBlockTab = new System.Windows.Forms.TabPage();
            this.EncoderDecoderTab = new System.Windows.Forms.TabPage();
            this.ModernEncodingGrpbx = new System.Windows.Forms.GroupBox();
            this.ModernShortOutputTxt = new System.Windows.Forms.TextBox();
            this.ModernIntegerOutputTxt = new System.Windows.Forms.TextBox();
            this.ModernShortInputTxt = new System.Windows.Forms.TextBox();
            this.ModernCypherShortBtn = new Sulakore.Components.SKoreButton();
            this.ModernCypherIntegerBtn = new Sulakore.Components.SKoreButton();
            this.ModernDecypherShortBtn = new Sulakore.Components.SKoreButton();
            this.ModernDecypherIntegerBtn = new Sulakore.Components.SKoreButton();
            this.ModernIntegerInputTxt = new System.Windows.Forms.TextBox();
            this.ToolboxTab = new System.Windows.Forms.TabPage();
            this.ExtensionsTab = new System.Windows.Forms.TabPage();
            this.EMiddleGlowPnl = new System.Windows.Forms.Panel();
            this.EExtensionLogoPctbx = new System.Windows.Forms.PictureBox();
            this.ETopGlowPnl = new System.Windows.Forms.Panel();
            this.ETanjiExtensionViewer = new Sulakore.Components.SKoreExtensionView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EVersionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.OOptionsTab = new Sulakore.Components.SKoreTabControl();
            this.OSettingsTab = new System.Windows.Forms.TabPage();
            this.OSAlwaysOnTopChckbx = new System.Windows.Forms.CheckBox();
            this.OSScreenEdgeSnappingChckbx = new System.Windows.Forms.CheckBox();
            this.OSCloseOnDisconnectChckbx = new System.Windows.Forms.CheckBox();
            this.OAboutTab = new System.Windows.Forms.TabPage();
            this.TanjiStrip.SuspendLayout();
            this.EExtensionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).BeginInit();
            this.ICConstructMenu.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.InjectionTab.SuspendLayout();
            this.IInjectionTabs.SuspendLayout();
            this.IConstructerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICCountTxt)).BeginInit();
            this.ISchedulerTab.SuspendLayout();
            this.IPrimitiveTab.SuspendLayout();
            this.IFiltersTab.SuspendLayout();
            this.IFFilterTabs.SuspendLayout();
            this.EncoderDecoderTab.SuspendLayout();
            this.ModernEncodingGrpbx.SuspendLayout();
            this.ExtensionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EExtensionLogoPctbx)).BeginInit();
            this.OptionsTab.SuspendLayout();
            this.OOptionsTab.SuspendLayout();
            this.OSettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionTxt,
            this.SchedulesTxt,
            this.ExtensionsActiveTxt,
            this.TanjiInfoTxt});
            this.TanjiStrip.Location = new System.Drawing.Point(0, 345);
            this.TanjiStrip.Name = "TanjiStrip";
            this.TanjiStrip.Size = new System.Drawing.Size(479, 24);
            this.TanjiStrip.SizingGrip = false;
            this.TanjiStrip.TabIndex = 4;
            this.TanjiStrip.Text = "statusStrip1";
            // 
            // VersionTxt
            // 
            this.VersionTxt.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.VersionTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.VersionTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.VersionTxt.Name = "VersionTxt";
            this.VersionTxt.Size = new System.Drawing.Size(50, 19);
            this.VersionTxt.Text = "v0.0.0.0";
            this.VersionTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.VersionTxt.Click += new System.EventHandler(this.VersionTxt_Click);
            // 
            // SchedulesTxt
            // 
            this.SchedulesTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SchedulesTxt.Name = "SchedulesTxt";
            this.SchedulesTxt.Size = new System.Drawing.Size(123, 19);
            this.SchedulesTxt.Text = "Schedules Active: 0/0";
            // 
            // ExtensionsActiveTxt
            // 
            this.ExtensionsActiveTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ExtensionsActiveTxt.Name = "ExtensionsActiveTxt";
            this.ExtensionsActiveTxt.Size = new System.Drawing.Size(125, 19);
            this.ExtensionsActiveTxt.Text = "Extensions Active: 0/0";
            // 
            // TanjiInfoTxt
            // 
            this.TanjiInfoTxt.IsLink = true;
            this.TanjiInfoTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TanjiInfoTxt.Name = "TanjiInfoTxt";
            this.TanjiInfoTxt.Size = new System.Drawing.Size(166, 19);
            this.TanjiInfoTxt.Spring = true;
            this.TanjiInfoTxt.Text = "ArachisH.GitHub.io/Tanji/";
            this.TanjiInfoTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiInfoTxt.Click += new System.EventHandler(this.TanjiInfoTxt_Click);
            // 
            // EExtensionMenu
            // 
            this.EExtensionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EOpenBtn,
            this.EUninstallBtn,
            this.EExtensionsSeperator,
            this.EInstallExtensionBtn});
            this.EExtensionMenu.Name = "ConstructMenu";
            this.EExtensionMenu.Size = new System.Drawing.Size(159, 76);
            // 
            // EOpenBtn
            // 
            this.EOpenBtn.Enabled = false;
            this.EOpenBtn.Name = "EOpenBtn";
            this.EOpenBtn.Size = new System.Drawing.Size(158, 22);
            this.EOpenBtn.Text = "Open";
            this.EOpenBtn.Click += new System.EventHandler(this.EOpenExtensionBtn_Click);
            // 
            // EUninstallBtn
            // 
            this.EUninstallBtn.Enabled = false;
            this.EUninstallBtn.Name = "EUninstallBtn";
            this.EUninstallBtn.Size = new System.Drawing.Size(158, 22);
            this.EUninstallBtn.Text = "Uninstall";
            this.EUninstallBtn.Click += new System.EventHandler(this.EUninstallExtensionBtn_Click);
            // 
            // EExtensionsSeperator
            // 
            this.EExtensionsSeperator.Name = "EExtensionsSeperator";
            this.EExtensionsSeperator.Size = new System.Drawing.Size(155, 6);
            // 
            // EInstallExtensionBtn
            // 
            this.EInstallExtensionBtn.Name = "EInstallExtensionBtn";
            this.EInstallExtensionBtn.Size = new System.Drawing.Size(158, 22);
            this.EInstallExtensionBtn.Text = "Install Extension";
            this.EInstallExtensionBtn.Click += new System.EventHandler(this.EInstallExtensionBtn_Click);
            // 
            // ChooseExtensionDlg
            // 
            this.ChooseExtensionDlg.DefaultExt = "dll";
            this.ChooseExtensionDlg.Filter = "Dynamic Link Library (*.dll)|*.dll";
            this.ChooseExtensionDlg.Title = "Tanji ~ Choose Extension";
            // 
            // ISBurstTxt
            // 
            this.ISBurstTxt.Location = new System.Drawing.Point(316, 214);
            this.ISBurstTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ISBurstTxt.Name = "ISBurstTxt";
            this.ISBurstTxt.Size = new System.Drawing.Size(70, 20);
            this.ISBurstTxt.TabIndex = 39;
            this.ISBurstTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TanjiTip.SetToolTip(this.ISBurstTxt, "The amount of times the packet is sent on every tick.");
            this.ISBurstTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ISIntervalTxt
            // 
            this.ISIntervalTxt.Location = new System.Drawing.Point(316, 175);
            this.ISIntervalTxt.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ISIntervalTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ISIntervalTxt.Name = "ISIntervalTxt";
            this.ISIntervalTxt.Size = new System.Drawing.Size(70, 20);
            this.ISIntervalTxt.TabIndex = 37;
            this.ISIntervalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TanjiTip.SetToolTip(this.ISIntervalTxt, "The speed in which the packet is sent in milliseconds.");
            this.ISIntervalTxt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ISDescriptionTxt
            // 
            this.ISDescriptionTxt.Location = new System.Drawing.Point(6, 214);
            this.ISDescriptionTxt.Name = "ISDescriptionTxt";
            this.ISDescriptionTxt.Size = new System.Drawing.Size(228, 20);
            this.ISDescriptionTxt.TabIndex = 31;
            this.TanjiTip.SetToolTip(this.ISDescriptionTxt, "The desciption of the schedule, this will be shown when hovering over the item in" +
        " the list.");
            // 
            // ISSchedulesLstVw
            // 
            this.ISSchedulesLstVw.CheckBoxes = true;
            this.ISSchedulesLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISPacketCol,
            this.ISDestinationCol,
            this.ISBurstCol,
            this.ISIntervalCol,
            this.ISStatusCol});
            this.ISSchedulesLstVw.FullRowSelect = true;
            this.ISSchedulesLstVw.GridLines = true;
            this.ISSchedulesLstVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ISSchedulesLstVw.HideSelection = false;
            this.ISSchedulesLstVw.Location = new System.Drawing.Point(6, 6);
            this.ISSchedulesLstVw.MultiSelect = false;
            this.ISSchedulesLstVw.Name = "ISSchedulesLstVw";
            this.ISSchedulesLstVw.ShowItemToolTips = true;
            this.ISSchedulesLstVw.Size = new System.Drawing.Size(380, 150);
            this.ISSchedulesLstVw.TabIndex = 41;
            this.TanjiTip.SetToolTip(this.ISSchedulesLstVw, "To toggle, double click the selected schedule.");
            this.ISSchedulesLstVw.UseCompatibleStateImageBehavior = false;
            this.ISSchedulesLstVw.View = System.Windows.Forms.View.Details;
            this.ISSchedulesLstVw.ScheduleTriggered += new System.EventHandler<Sulakore.Protocol.HScheduleTriggeredEventArgs>(this.ISSchedulesLstVw_ScheduleTriggered);
            this.ISSchedulesLstVw.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ISSchedulesLstVw_ItemSelectionChanged);
            // 
            // ISPacketCol
            // 
            this.ISPacketCol.Text = "Packet";
            this.ISPacketCol.Width = 145;
            // 
            // ISDestinationCol
            // 
            this.ISDestinationCol.Text = "Destination";
            this.ISDestinationCol.Width = 65;
            // 
            // ISBurstCol
            // 
            this.ISBurstCol.Text = "Burst";
            this.ISBurstCol.Width = 48;
            // 
            // ISIntervalCol
            // 
            this.ISIntervalCol.Text = "Interval";
            this.ISIntervalCol.Width = 48;
            // 
            // ISStatusCol
            // 
            this.ISStatusCol.Text = "Status";
            this.ISStatusCol.Width = 52;
            // 
            // ICConstructMenu
            // 
            this.ICConstructMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ICCopyPacketBtn,
            this.ICTransferToBtn});
            this.ICConstructMenu.Name = "ConstructMenu";
            this.ICConstructMenu.Size = new System.Drawing.Size(141, 48);
            // 
            // ICCopyPacketBtn
            // 
            this.ICCopyPacketBtn.Name = "ICCopyPacketBtn";
            this.ICCopyPacketBtn.Size = new System.Drawing.Size(140, 22);
            this.ICCopyPacketBtn.Text = "Copy Packet";
            this.ICCopyPacketBtn.Click += new System.EventHandler(this.ICCopyPacketBtn_Click);
            // 
            // ICTransferToBtn
            // 
            this.ICTransferToBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ICSchedulerBtn,
            this.ICPrimitiveBtn,
            this.ICTransferSeparator,
            this.ICInjectionBtn});
            this.ICTransferToBtn.Name = "ICTransferToBtn";
            this.ICTransferToBtn.Size = new System.Drawing.Size(140, 22);
            this.ICTransferToBtn.Text = "Transfer To";
            // 
            // ICSchedulerBtn
            // 
            this.ICSchedulerBtn.Name = "ICSchedulerBtn";
            this.ICSchedulerBtn.Size = new System.Drawing.Size(163, 22);
            this.ICSchedulerBtn.Text = "Scheduler";
            this.ICSchedulerBtn.Click += new System.EventHandler(this.ICSchedulerBtn_Click);
            // 
            // ICPrimitiveBtn
            // 
            this.ICPrimitiveBtn.Name = "ICPrimitiveBtn";
            this.ICPrimitiveBtn.Size = new System.Drawing.Size(163, 22);
            this.ICPrimitiveBtn.Text = "Primitive";
            this.ICPrimitiveBtn.Click += new System.EventHandler(this.ICPrimitiveBtn_Click);
            // 
            // ICTransferSeparator
            // 
            this.ICTransferSeparator.Name = "ICTransferSeparator";
            this.ICTransferSeparator.Size = new System.Drawing.Size(160, 6);
            // 
            // ICInjectionBtn
            // 
            this.ICInjectionBtn.Name = "ICInjectionBtn";
            this.ICInjectionBtn.Size = new System.Drawing.Size(163, 22);
            this.ICInjectionBtn.Text = "Injection (Below)";
            this.ICInjectionBtn.Click += new System.EventHandler(this.ICInjectionBtn_Click);
            // 
            // TanjiTabs
            // 
            this.TanjiTabs.Controls.Add(this.InjectionTab);
            this.TanjiTabs.Controls.Add(this.EncoderDecoderTab);
            this.TanjiTabs.Controls.Add(this.ToolboxTab);
            this.TanjiTabs.Controls.Add(this.ExtensionsTab);
            this.TanjiTabs.Controls.Add(this.OptionsTab);
            this.TanjiTabs.DisplayBoundary = true;
            this.TanjiTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanjiTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TanjiTabs.Location = new System.Drawing.Point(0, 0);
            this.TanjiTabs.Name = "TanjiTabs";
            this.TanjiTabs.SelectedIndex = 0;
            this.TanjiTabs.Size = new System.Drawing.Size(479, 345);
            this.TanjiTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TanjiTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiTabs.TabIndex = 0;
            // 
            // InjectionTab
            // 
            this.InjectionTab.BackColor = System.Drawing.Color.White;
            this.InjectionTab.Controls.Add(this.IPacketTxt);
            this.InjectionTab.Controls.Add(this.ISendToClientBtn);
            this.InjectionTab.Controls.Add(this.ISendToServerBtn);
            this.InjectionTab.Controls.Add(this.IInjectionTabs);
            this.InjectionTab.Location = new System.Drawing.Point(4, 28);
            this.InjectionTab.Name = "InjectionTab";
            this.InjectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.InjectionTab.Size = new System.Drawing.Size(471, 313);
            this.InjectionTab.TabIndex = 0;
            this.InjectionTab.Text = "Injection";
            // 
            // IPacketTxt
            // 
            this.IPacketTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPacketTxt.Location = new System.Drawing.Point(6, 286);
            this.IPacketTxt.MaxLength = 2147483647;
            this.IPacketTxt.Name = "IPacketTxt";
            this.IPacketTxt.Size = new System.Drawing.Size(247, 20);
            this.IPacketTxt.TabIndex = 5;
            // 
            // ISendToClientBtn
            // 
            this.ISendToClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ISendToClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISendToClientBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISendToClientBtn.Location = new System.Drawing.Point(259, 285);
            this.ISendToClientBtn.Name = "ISendToClientBtn";
            this.ISendToClientBtn.Size = new System.Drawing.Size(100, 22);
            this.ISendToClientBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISendToClientBtn.TabIndex = 4;
            this.ISendToClientBtn.Text = "Send To Client";
            this.ISendToClientBtn.Click += new System.EventHandler(this.SendToClientBtn_Click);
            // 
            // ISendToServerBtn
            // 
            this.ISendToServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ISendToServerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISendToServerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISendToServerBtn.Location = new System.Drawing.Point(365, 285);
            this.ISendToServerBtn.Name = "ISendToServerBtn";
            this.ISendToServerBtn.Size = new System.Drawing.Size(100, 22);
            this.ISendToServerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISendToServerBtn.TabIndex = 3;
            this.ISendToServerBtn.Text = "Send To Server";
            this.ISendToServerBtn.Click += new System.EventHandler(this.SendToServerBtn_Click);
            // 
            // IInjectionTabs
            // 
            this.IInjectionTabs.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.IInjectionTabs.Controls.Add(this.IConstructerTab);
            this.IInjectionTabs.Controls.Add(this.ISchedulerTab);
            this.IInjectionTabs.Controls.Add(this.IPrimitiveTab);
            this.IInjectionTabs.Controls.Add(this.ITriggersTab);
            this.IInjectionTabs.Controls.Add(this.IFiltersTab);
            this.IInjectionTabs.DisplayBoundary = true;
            this.IInjectionTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.IInjectionTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.IInjectionTabs.ItemSize = new System.Drawing.Size(65, 24);
            this.IInjectionTabs.Location = new System.Drawing.Point(3, 3);
            this.IInjectionTabs.Multiline = true;
            this.IInjectionTabs.Name = "IInjectionTabs";
            this.IInjectionTabs.SelectedIndex = 0;
            this.IInjectionTabs.Size = new System.Drawing.Size(465, 276);
            this.IInjectionTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.IInjectionTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IInjectionTabs.TabIndex = 0;
            this.IInjectionTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.IInjectionTabs_Selected);
            // 
            // IConstructerTab
            // 
            this.IConstructerTab.BackColor = System.Drawing.Color.White;
            this.IConstructerTab.Controls.Add(this.ICChunksRightGlowPnl);
            this.IConstructerTab.Controls.Add(this.ICChunksLeftGlowPnl);
            this.IConstructerTab.Controls.Add(this.ICChunkCountLbl);
            this.IConstructerTab.Controls.Add(this.ICCountTxt);
            this.IConstructerTab.Controls.Add(this.ICCountLbl);
            this.IConstructerTab.Controls.Add(this.ICRemoveBtn);
            this.IConstructerTab.Controls.Add(this.ICMoveDownBtn);
            this.IConstructerTab.Controls.Add(this.ICMoveUpBtn);
            this.IConstructerTab.Controls.Add(this.ICClearBtn);
            this.IConstructerTab.Controls.Add(this.ICAppendBooleanBtn);
            this.IConstructerTab.Controls.Add(this.ICAppendStringBtn);
            this.IConstructerTab.Controls.Add(this.ICAppendIntegerBtn);
            this.IConstructerTab.Controls.Add(this.ICHeaderLbl);
            this.IConstructerTab.Controls.Add(this.ICHeaderTxt);
            this.IConstructerTab.Controls.Add(this.ICValueLbl);
            this.IConstructerTab.Controls.Add(this.ICValueTxt);
            this.IConstructerTab.Controls.Add(this.ICConstructerLstVw);
            this.IConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.IConstructerTab.Name = "IConstructerTab";
            this.IConstructerTab.Padding = new System.Windows.Forms.Padding(3);
            this.IConstructerTab.Size = new System.Drawing.Size(392, 268);
            this.IConstructerTab.TabIndex = 1;
            this.IConstructerTab.Text = "Constructer";
            // 
            // ICChunksRightGlowPnl
            // 
            this.ICChunksRightGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICChunksRightGlowPnl.Location = new System.Drawing.Point(385, 240);
            this.ICChunksRightGlowPnl.Name = "ICChunksRightGlowPnl";
            this.ICChunksRightGlowPnl.Size = new System.Drawing.Size(1, 22);
            this.ICChunksRightGlowPnl.TabIndex = 27;
            // 
            // ICChunksLeftGlowPnl
            // 
            this.ICChunksLeftGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICChunksLeftGlowPnl.Location = new System.Drawing.Point(270, 240);
            this.ICChunksLeftGlowPnl.Name = "ICChunksLeftGlowPnl";
            this.ICChunksLeftGlowPnl.Size = new System.Drawing.Size(1, 22);
            this.ICChunksLeftGlowPnl.TabIndex = 26;
            // 
            // ICChunkCountLbl
            // 
            this.ICChunkCountLbl.Location = new System.Drawing.Point(273, 240);
            this.ICChunkCountLbl.Name = "ICChunkCountLbl";
            this.ICChunkCountLbl.Size = new System.Drawing.Size(110, 22);
            this.ICChunkCountLbl.TabIndex = 25;
            this.ICChunkCountLbl.Text = "Chunk Count: 0";
            this.ICChunkCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ICCountTxt
            // 
            this.ICCountTxt.Location = new System.Drawing.Point(326, 19);
            this.ICCountTxt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ICCountTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ICCountTxt.Name = "ICCountTxt";
            this.ICCountTxt.Size = new System.Drawing.Size(60, 20);
            this.ICCountTxt.TabIndex = 24;
            this.ICCountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICCountTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ICCountLbl
            // 
            this.ICCountLbl.AutoSize = true;
            this.ICCountLbl.Location = new System.Drawing.Point(324, 3);
            this.ICCountLbl.Name = "ICCountLbl";
            this.ICCountLbl.Size = new System.Drawing.Size(35, 13);
            this.ICCountLbl.TabIndex = 23;
            this.ICCountLbl.Text = "Count";
            // 
            // ICRemoveBtn
            // 
            this.ICRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICRemoveBtn.Enabled = false;
            this.ICRemoveBtn.Location = new System.Drawing.Point(6, 240);
            this.ICRemoveBtn.Name = "ICRemoveBtn";
            this.ICRemoveBtn.Size = new System.Drawing.Size(82, 22);
            this.ICRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICRemoveBtn.TabIndex = 21;
            this.ICRemoveBtn.Text = "Remove";
            this.ICRemoveBtn.Click += new System.EventHandler(this.ICRemoveBtn_Click);
            // 
            // ICMoveDownBtn
            // 
            this.ICMoveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICMoveDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICMoveDownBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICMoveDownBtn.Enabled = false;
            this.ICMoveDownBtn.Location = new System.Drawing.Point(182, 240);
            this.ICMoveDownBtn.Name = "ICMoveDownBtn";
            this.ICMoveDownBtn.Size = new System.Drawing.Size(82, 22);
            this.ICMoveDownBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICMoveDownBtn.TabIndex = 19;
            this.ICMoveDownBtn.Text = "Move Down";
            this.ICMoveDownBtn.Click += new System.EventHandler(this.ICMoveDownBtn_Click);
            // 
            // ICMoveUpBtn
            // 
            this.ICMoveUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICMoveUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICMoveUpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICMoveUpBtn.Enabled = false;
            this.ICMoveUpBtn.Location = new System.Drawing.Point(94, 240);
            this.ICMoveUpBtn.Name = "ICMoveUpBtn";
            this.ICMoveUpBtn.Size = new System.Drawing.Size(82, 22);
            this.ICMoveUpBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICMoveUpBtn.TabIndex = 18;
            this.ICMoveUpBtn.Text = "Move Up";
            this.ICMoveUpBtn.Click += new System.EventHandler(this.ICMoveUpBtn_Click);
            // 
            // ICClearBtn
            // 
            this.ICClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICClearBtn.Location = new System.Drawing.Point(7, 45);
            this.ICClearBtn.Name = "ICClearBtn";
            this.ICClearBtn.Size = new System.Drawing.Size(67, 22);
            this.ICClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICClearBtn.TabIndex = 17;
            this.ICClearBtn.Text = "Clear";
            this.ICClearBtn.Click += new System.EventHandler(this.ICClearBtn_Click);
            // 
            // ICAppendBooleanBtn
            // 
            this.ICAppendBooleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendBooleanBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendBooleanBtn.Location = new System.Drawing.Point(288, 45);
            this.ICAppendBooleanBtn.Name = "ICAppendBooleanBtn";
            this.ICAppendBooleanBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendBooleanBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICAppendBooleanBtn.TabIndex = 16;
            this.ICAppendBooleanBtn.Text = "Append Boolean";
            this.ICAppendBooleanBtn.Click += new System.EventHandler(this.ICAppendBooleanBtn_Click);
            // 
            // ICAppendStringBtn
            // 
            this.ICAppendStringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendStringBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendStringBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendStringBtn.Location = new System.Drawing.Point(184, 45);
            this.ICAppendStringBtn.Name = "ICAppendStringBtn";
            this.ICAppendStringBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendStringBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICAppendStringBtn.TabIndex = 15;
            this.ICAppendStringBtn.Text = "Append String";
            this.ICAppendStringBtn.Click += new System.EventHandler(this.ICAppendStringBtn_Click);
            // 
            // ICAppendIntegerBtn
            // 
            this.ICAppendIntegerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendIntegerBtn.Location = new System.Drawing.Point(80, 45);
            this.ICAppendIntegerBtn.Name = "ICAppendIntegerBtn";
            this.ICAppendIntegerBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICAppendIntegerBtn.TabIndex = 14;
            this.ICAppendIntegerBtn.Text = "Append Integer";
            this.ICAppendIntegerBtn.Click += new System.EventHandler(this.ICAppendIntegerBtn_Click);
            // 
            // ICHeaderLbl
            // 
            this.ICHeaderLbl.AutoSize = true;
            this.ICHeaderLbl.Location = new System.Drawing.Point(3, 3);
            this.ICHeaderLbl.Name = "ICHeaderLbl";
            this.ICHeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.ICHeaderLbl.TabIndex = 13;
            this.ICHeaderLbl.Text = "Header";
            // 
            // ICHeaderTxt
            // 
            this.ICHeaderTxt.Location = new System.Drawing.Point(6, 19);
            this.ICHeaderTxt.MaxLength = 4;
            this.ICHeaderTxt.Name = "ICHeaderTxt";
            this.ICHeaderTxt.Size = new System.Drawing.Size(67, 20);
            this.ICHeaderTxt.TabIndex = 12;
            this.ICHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICHeaderTxt.TextChanged += new System.EventHandler(this.ICHeaderTxt_TextChanged);
            // 
            // ICValueLbl
            // 
            this.ICValueLbl.AutoSize = true;
            this.ICValueLbl.Location = new System.Drawing.Point(76, 3);
            this.ICValueLbl.Name = "ICValueLbl";
            this.ICValueLbl.Size = new System.Drawing.Size(34, 13);
            this.ICValueLbl.TabIndex = 11;
            this.ICValueLbl.Text = "Value";
            // 
            // ICValueTxt
            // 
            this.ICValueTxt.Location = new System.Drawing.Point(79, 19);
            this.ICValueTxt.Name = "ICValueTxt";
            this.ICValueTxt.Size = new System.Drawing.Size(241, 20);
            this.ICValueTxt.TabIndex = 10;
            this.ICValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICValueTxt.TextChanged += new System.EventHandler(this.ICValueTxt_TextChanged);
            // 
            // ICConstructerLstVw
            // 
            this.ICConstructerLstVw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ICConstructerLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ICTypeCol,
            this.ICValueCol,
            this.ICEncodedCol});
            this.ICConstructerLstVw.ContextMenuStrip = this.ICConstructMenu;
            this.ICConstructerLstVw.FullRowSelect = true;
            this.ICConstructerLstVw.GridLines = true;
            this.ICConstructerLstVw.Header = ((ushort)(0));
            this.ICConstructerLstVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ICConstructerLstVw.HideSelection = false;
            this.ICConstructerLstVw.Location = new System.Drawing.Point(6, 73);
            this.ICConstructerLstVw.MultiSelect = false;
            this.ICConstructerLstVw.Name = "ICConstructerLstVw";
            this.ICConstructerLstVw.ShowItemToolTips = true;
            this.ICConstructerLstVw.Size = new System.Drawing.Size(380, 161);
            this.ICConstructerLstVw.TabIndex = 0;
            this.ICConstructerLstVw.UseCompatibleStateImageBehavior = false;
            this.ICConstructerLstVw.View = System.Windows.Forms.View.Details;
            this.ICConstructerLstVw.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ICConstructerLstVw_ItemSelectionChanged);
            this.ICConstructerLstVw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ICConstructerLstVw_MouseDoubleClick);
            // 
            // ICTypeCol
            // 
            this.ICTypeCol.Text = "Type";
            this.ICTypeCol.Width = 72;
            // 
            // ICValueCol
            // 
            this.ICValueCol.Text = "Value";
            this.ICValueCol.Width = 137;
            // 
            // ICEncodedCol
            // 
            this.ICEncodedCol.Text = "Encoded";
            this.ICEncodedCol.Width = 150;
            // 
            // ISchedulerTab
            // 
            this.ISchedulerTab.BackColor = System.Drawing.Color.White;
            this.ISchedulerTab.Controls.Add(this.ISClearBtn);
            this.ISchedulerTab.Controls.Add(this.ISAutoStartChckbx);
            this.ISchedulerTab.Controls.Add(this.ISBurstLbl);
            this.ISchedulerTab.Controls.Add(this.ISBurstTxt);
            this.ISchedulerTab.Controls.Add(this.ISStopAllBtn);
            this.ISchedulerTab.Controls.Add(this.ISIntervalLbl);
            this.ISchedulerTab.Controls.Add(this.ISIntervalTxt);
            this.ISchedulerTab.Controls.Add(this.ISDestinationLbl);
            this.ISchedulerTab.Controls.Add(this.ISDestinationTxt);
            this.ISchedulerTab.Controls.Add(this.ISPacketLbl);
            this.ISchedulerTab.Controls.Add(this.ISPacketTxt);
            this.ISchedulerTab.Controls.Add(this.ISDescriptionLbl);
            this.ISchedulerTab.Controls.Add(this.ISDescriptionTxt);
            this.ISchedulerTab.Controls.Add(this.ISStartAllBtn);
            this.ISchedulerTab.Controls.Add(this.ISRemoveBtn);
            this.ISchedulerTab.Controls.Add(this.ISCreateBtn);
            this.ISchedulerTab.Controls.Add(this.ISSchedulesLstVw);
            this.ISchedulerTab.Location = new System.Drawing.Point(4, 4);
            this.ISchedulerTab.Name = "ISchedulerTab";
            this.ISchedulerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ISchedulerTab.Size = new System.Drawing.Size(392, 268);
            this.ISchedulerTab.TabIndex = 2;
            this.ISchedulerTab.Text = "Scheduler";
            // 
            // ISClearBtn
            // 
            this.ISClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISClearBtn.Enabled = false;
            this.ISClearBtn.Location = new System.Drawing.Point(158, 240);
            this.ISClearBtn.Name = "ISClearBtn";
            this.ISClearBtn.Size = new System.Drawing.Size(76, 22);
            this.ISClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISClearBtn.TabIndex = 43;
            this.ISClearBtn.Text = "Clear";
            this.ISClearBtn.Click += new System.EventHandler(this.ISClearBtn_Click);
            // 
            // ISAutoStartChckbx
            // 
            this.ISAutoStartChckbx.AutoSize = true;
            this.ISAutoStartChckbx.Checked = true;
            this.ISAutoStartChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ISAutoStartChckbx.Location = new System.Drawing.Point(244, 158);
            this.ISAutoStartChckbx.Name = "ISAutoStartChckbx";
            this.ISAutoStartChckbx.Size = new System.Drawing.Size(73, 17);
            this.ISAutoStartChckbx.TabIndex = 42;
            this.ISAutoStartChckbx.Text = "Auto Start";
            this.ISAutoStartChckbx.UseVisualStyleBackColor = true;
            this.ISAutoStartChckbx.CheckedChanged += new System.EventHandler(this.ISAutoStartChckbx_CheckedChanged);
            // 
            // ISBurstLbl
            // 
            this.ISBurstLbl.AutoSize = true;
            this.ISBurstLbl.Location = new System.Drawing.Point(313, 198);
            this.ISBurstLbl.Name = "ISBurstLbl";
            this.ISBurstLbl.Size = new System.Drawing.Size(31, 13);
            this.ISBurstLbl.TabIndex = 40;
            this.ISBurstLbl.Text = "Burst";
            // 
            // ISStopAllBtn
            // 
            this.ISStopAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISStopAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISStopAllBtn.Enabled = false;
            this.ISStopAllBtn.Location = new System.Drawing.Point(82, 240);
            this.ISStopAllBtn.Name = "ISStopAllBtn";
            this.ISStopAllBtn.Size = new System.Drawing.Size(70, 22);
            this.ISStopAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISStopAllBtn.TabIndex = 28;
            this.ISStopAllBtn.Text = "Stop All";
            this.ISStopAllBtn.Click += new System.EventHandler(this.ISStopAllBtn_Click);
            // 
            // ISIntervalLbl
            // 
            this.ISIntervalLbl.AutoSize = true;
            this.ISIntervalLbl.Location = new System.Drawing.Point(313, 159);
            this.ISIntervalLbl.Name = "ISIntervalLbl";
            this.ISIntervalLbl.Size = new System.Drawing.Size(64, 13);
            this.ISIntervalLbl.TabIndex = 38;
            this.ISIntervalLbl.Text = "Interval (ms)";
            // 
            // ISDestinationLbl
            // 
            this.ISDestinationLbl.AutoSize = true;
            this.ISDestinationLbl.Location = new System.Drawing.Point(237, 197);
            this.ISDestinationLbl.Name = "ISDestinationLbl";
            this.ISDestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.ISDestinationLbl.TabIndex = 36;
            this.ISDestinationLbl.Text = "Destination";
            // 
            // ISDestinationTxt
            // 
            this.ISDestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISDestinationTxt.FormattingEnabled = true;
            this.ISDestinationTxt.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.ISDestinationTxt.Location = new System.Drawing.Point(240, 213);
            this.ISDestinationTxt.Name = "ISDestinationTxt";
            this.ISDestinationTxt.Size = new System.Drawing.Size(70, 21);
            this.ISDestinationTxt.TabIndex = 35;
            // 
            // ISPacketLbl
            // 
            this.ISPacketLbl.AutoSize = true;
            this.ISPacketLbl.Location = new System.Drawing.Point(3, 159);
            this.ISPacketLbl.Name = "ISPacketLbl";
            this.ISPacketLbl.Size = new System.Drawing.Size(41, 13);
            this.ISPacketLbl.TabIndex = 34;
            this.ISPacketLbl.Text = "Packet";
            // 
            // ISPacketTxt
            // 
            this.ISPacketTxt.Location = new System.Drawing.Point(6, 175);
            this.ISPacketTxt.MaxLength = 2147483647;
            this.ISPacketTxt.Name = "ISPacketTxt";
            this.ISPacketTxt.Size = new System.Drawing.Size(304, 20);
            this.ISPacketTxt.TabIndex = 33;
            // 
            // ISDescriptionLbl
            // 
            this.ISDescriptionLbl.AutoSize = true;
            this.ISDescriptionLbl.Location = new System.Drawing.Point(3, 198);
            this.ISDescriptionLbl.Name = "ISDescriptionLbl";
            this.ISDescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.ISDescriptionLbl.TabIndex = 32;
            this.ISDescriptionLbl.Text = "Description";
            // 
            // ISStartAllBtn
            // 
            this.ISStartAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISStartAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISStartAllBtn.Enabled = false;
            this.ISStartAllBtn.Location = new System.Drawing.Point(6, 240);
            this.ISStartAllBtn.Name = "ISStartAllBtn";
            this.ISStartAllBtn.Size = new System.Drawing.Size(70, 22);
            this.ISStartAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISStartAllBtn.TabIndex = 29;
            this.ISStartAllBtn.Text = "Start All";
            this.ISStartAllBtn.Click += new System.EventHandler(this.ISStartAllBtn_Click);
            // 
            // ISRemoveBtn
            // 
            this.ISRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISRemoveBtn.Enabled = false;
            this.ISRemoveBtn.Location = new System.Drawing.Point(240, 240);
            this.ISRemoveBtn.Name = "ISRemoveBtn";
            this.ISRemoveBtn.Size = new System.Drawing.Size(70, 22);
            this.ISRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISRemoveBtn.TabIndex = 26;
            this.ISRemoveBtn.Text = "Remove";
            this.ISRemoveBtn.Click += new System.EventHandler(this.ISRemoveBtn_Click);
            // 
            // ISCreateBtn
            // 
            this.ISCreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISCreateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISCreateBtn.Location = new System.Drawing.Point(316, 240);
            this.ISCreateBtn.Name = "ISCreateBtn";
            this.ISCreateBtn.Size = new System.Drawing.Size(70, 22);
            this.ISCreateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISCreateBtn.TabIndex = 25;
            this.ISCreateBtn.Text = "Create";
            this.ISCreateBtn.Click += new System.EventHandler(this.ISCreateBtn_Click);
            // 
            // IPrimitiveTab
            // 
            this.IPrimitiveTab.BackColor = System.Drawing.Color.White;
            this.IPrimitiveTab.Controls.Add(this.IPIsCorruptedLbl);
            this.IPrimitiveTab.Controls.Add(this.IPPacketInfoLbl);
            this.IPrimitiveTab.Controls.Add(this.IPPacketTxt);
            this.IPrimitiveTab.Location = new System.Drawing.Point(4, 4);
            this.IPrimitiveTab.Name = "IPrimitiveTab";
            this.IPrimitiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.IPrimitiveTab.Size = new System.Drawing.Size(392, 268);
            this.IPrimitiveTab.TabIndex = 0;
            this.IPrimitiveTab.Text = "Primitive";
            // 
            // IPIsCorruptedLbl
            // 
            this.IPIsCorruptedLbl.AutoSize = true;
            this.IPIsCorruptedLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.IPIsCorruptedLbl.Location = new System.Drawing.Point(165, 3);
            this.IPIsCorruptedLbl.Name = "IPIsCorruptedLbl";
            this.IPIsCorruptedLbl.Size = new System.Drawing.Size(29, 13);
            this.IPIsCorruptedLbl.TabIndex = 2;
            this.IPIsCorruptedLbl.Text = "True";
            // 
            // IPPacketInfoLbl
            // 
            this.IPPacketInfoLbl.AutoSize = true;
            this.IPPacketInfoLbl.Location = new System.Drawing.Point(6, 3);
            this.IPPacketInfoLbl.Name = "IPPacketInfoLbl";
            this.IPPacketInfoLbl.Size = new System.Drawing.Size(164, 13);
            this.IPPacketInfoLbl.TabIndex = 1;
            this.IPPacketInfoLbl.Text = "Header: 0 | Length: 0 | Corrupted:";
            // 
            // IPPacketTxt
            // 
            this.IPPacketTxt.Location = new System.Drawing.Point(6, 19);
            this.IPPacketTxt.MaxLength = 2147483647;
            this.IPPacketTxt.Multiline = true;
            this.IPPacketTxt.Name = "IPPacketTxt";
            this.IPPacketTxt.Size = new System.Drawing.Size(379, 243);
            this.IPPacketTxt.TabIndex = 0;
            this.IPPacketTxt.TextChanged += new System.EventHandler(this.IPPacketTxt_TextChanged);
            // 
            // ITriggersTab
            // 
            this.ITriggersTab.BackColor = System.Drawing.Color.White;
            this.ITriggersTab.Location = new System.Drawing.Point(4, 4);
            this.ITriggersTab.Name = "ITriggersTab";
            this.ITriggersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ITriggersTab.Size = new System.Drawing.Size(392, 268);
            this.ITriggersTab.TabIndex = 3;
            this.ITriggersTab.Text = "Triggers";
            // 
            // IFiltersTab
            // 
            this.IFiltersTab.BackColor = System.Drawing.Color.White;
            this.IFiltersTab.Controls.Add(this.IFFilterTabs);
            this.IFiltersTab.Location = new System.Drawing.Point(4, 4);
            this.IFiltersTab.Name = "IFiltersTab";
            this.IFiltersTab.Padding = new System.Windows.Forms.Padding(3);
            this.IFiltersTab.Size = new System.Drawing.Size(392, 268);
            this.IFiltersTab.TabIndex = 4;
            this.IFiltersTab.Text = "Filters";
            // 
            // IFFilterTabs
            // 
            this.IFFilterTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.IFFilterTabs.Controls.Add(this.IFReplaceTab);
            this.IFFilterTabs.Controls.Add(this.IFBlockTab);
            this.IFFilterTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IFFilterTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.IFFilterTabs.ItemSize = new System.Drawing.Size(48, 24);
            this.IFFilterTabs.Location = new System.Drawing.Point(3, 3);
            this.IFFilterTabs.Multiline = true;
            this.IFFilterTabs.Name = "IFFilterTabs";
            this.IFFilterTabs.SelectedIndex = 0;
            this.IFFilterTabs.Size = new System.Drawing.Size(386, 262);
            this.IFFilterTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.IFFilterTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IFFilterTabs.TabIndex = 0;
            // 
            // IFReplaceTab
            // 
            this.IFReplaceTab.BackColor = System.Drawing.Color.White;
            this.IFReplaceTab.Location = new System.Drawing.Point(52, 4);
            this.IFReplaceTab.Name = "IFReplaceTab";
            this.IFReplaceTab.Padding = new System.Windows.Forms.Padding(3);
            this.IFReplaceTab.Size = new System.Drawing.Size(330, 254);
            this.IFReplaceTab.TabIndex = 0;
            this.IFReplaceTab.Text = "Replace";
            // 
            // IFBlockTab
            // 
            this.IFBlockTab.BackColor = System.Drawing.Color.White;
            this.IFBlockTab.Location = new System.Drawing.Point(52, 4);
            this.IFBlockTab.Name = "IFBlockTab";
            this.IFBlockTab.Padding = new System.Windows.Forms.Padding(3);
            this.IFBlockTab.Size = new System.Drawing.Size(330, 254);
            this.IFBlockTab.TabIndex = 1;
            this.IFBlockTab.Text = "Block";
            // 
            // EncoderDecoderTab
            // 
            this.EncoderDecoderTab.BackColor = System.Drawing.Color.White;
            this.EncoderDecoderTab.Controls.Add(this.ModernEncodingGrpbx);
            this.EncoderDecoderTab.Location = new System.Drawing.Point(4, 28);
            this.EncoderDecoderTab.Name = "EncoderDecoderTab";
            this.EncoderDecoderTab.Padding = new System.Windows.Forms.Padding(3);
            this.EncoderDecoderTab.Size = new System.Drawing.Size(471, 313);
            this.EncoderDecoderTab.TabIndex = 1;
            this.EncoderDecoderTab.Text = "Encoder/Decoder";
            // 
            // ModernEncodingGrpbx
            // 
            this.ModernEncodingGrpbx.Controls.Add(this.ModernShortOutputTxt);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernIntegerOutputTxt);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernShortInputTxt);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernCypherShortBtn);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernCypherIntegerBtn);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernDecypherShortBtn);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernDecypherIntegerBtn);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernIntegerInputTxt);
            this.ModernEncodingGrpbx.Location = new System.Drawing.Point(6, 6);
            this.ModernEncodingGrpbx.Name = "ModernEncodingGrpbx";
            this.ModernEncodingGrpbx.Size = new System.Drawing.Size(459, 79);
            this.ModernEncodingGrpbx.TabIndex = 21;
            this.ModernEncodingGrpbx.TabStop = false;
            this.ModernEncodingGrpbx.Text = "Modern Encoding ( BigEndian )";
            // 
            // ModernShortOutputTxt
            // 
            this.ModernShortOutputTxt.Location = new System.Drawing.Point(233, 50);
            this.ModernShortOutputTxt.Name = "ModernShortOutputTxt";
            this.ModernShortOutputTxt.Size = new System.Drawing.Size(117, 20);
            this.ModernShortOutputTxt.TabIndex = 17;
            this.ModernShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModernIntegerOutputTxt
            // 
            this.ModernIntegerOutputTxt.Location = new System.Drawing.Point(233, 21);
            this.ModernIntegerOutputTxt.Name = "ModernIntegerOutputTxt";
            this.ModernIntegerOutputTxt.Size = new System.Drawing.Size(117, 20);
            this.ModernIntegerOutputTxt.TabIndex = 16;
            this.ModernIntegerOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModernShortInputTxt
            // 
            this.ModernShortInputTxt.Location = new System.Drawing.Point(110, 50);
            this.ModernShortInputTxt.Name = "ModernShortInputTxt";
            this.ModernShortInputTxt.Size = new System.Drawing.Size(117, 20);
            this.ModernShortInputTxt.TabIndex = 15;
            this.ModernShortInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModernCypherShortBtn
            // 
            this.ModernCypherShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModernCypherShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModernCypherShortBtn.Location = new System.Drawing.Point(6, 48);
            this.ModernCypherShortBtn.Name = "ModernCypherShortBtn";
            this.ModernCypherShortBtn.Size = new System.Drawing.Size(98, 23);
            this.ModernCypherShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ModernCypherShortBtn.TabIndex = 12;
            this.ModernCypherShortBtn.Text = "Cypher Short";
            this.ModernCypherShortBtn.Click += new System.EventHandler(this.ModernCypherShortBtn_Click);
            // 
            // ModernCypherIntegerBtn
            // 
            this.ModernCypherIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModernCypherIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModernCypherIntegerBtn.Location = new System.Drawing.Point(6, 19);
            this.ModernCypherIntegerBtn.Name = "ModernCypherIntegerBtn";
            this.ModernCypherIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.ModernCypherIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ModernCypherIntegerBtn.TabIndex = 11;
            this.ModernCypherIntegerBtn.Text = "Cypher Integer";
            this.ModernCypherIntegerBtn.Click += new System.EventHandler(this.ModernCypherIntegerBtn_Click);
            // 
            // ModernDecypherShortBtn
            // 
            this.ModernDecypherShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModernDecypherShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModernDecypherShortBtn.Location = new System.Drawing.Point(356, 48);
            this.ModernDecypherShortBtn.Name = "ModernDecypherShortBtn";
            this.ModernDecypherShortBtn.Size = new System.Drawing.Size(98, 23);
            this.ModernDecypherShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ModernDecypherShortBtn.TabIndex = 14;
            this.ModernDecypherShortBtn.Text = "Decypher Short";
            this.ModernDecypherShortBtn.Click += new System.EventHandler(this.ModernDecypherShortBtn_Click);
            // 
            // ModernDecypherIntegerBtn
            // 
            this.ModernDecypherIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModernDecypherIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModernDecypherIntegerBtn.Location = new System.Drawing.Point(356, 19);
            this.ModernDecypherIntegerBtn.Name = "ModernDecypherIntegerBtn";
            this.ModernDecypherIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.ModernDecypherIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ModernDecypherIntegerBtn.TabIndex = 13;
            this.ModernDecypherIntegerBtn.Text = "Decypher Integer";
            this.ModernDecypherIntegerBtn.Click += new System.EventHandler(this.ModernDecypherIntegerBtn_Click);
            // 
            // ModernIntegerInputTxt
            // 
            this.ModernIntegerInputTxt.Location = new System.Drawing.Point(110, 21);
            this.ModernIntegerInputTxt.Name = "ModernIntegerInputTxt";
            this.ModernIntegerInputTxt.Size = new System.Drawing.Size(117, 20);
            this.ModernIntegerInputTxt.TabIndex = 10;
            this.ModernIntegerInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToolboxTab
            // 
            this.ToolboxTab.BackColor = System.Drawing.Color.White;
            this.ToolboxTab.Location = new System.Drawing.Point(4, 28);
            this.ToolboxTab.Name = "ToolboxTab";
            this.ToolboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.ToolboxTab.Size = new System.Drawing.Size(471, 313);
            this.ToolboxTab.TabIndex = 2;
            this.ToolboxTab.Text = "Toolbox";
            // 
            // ExtensionsTab
            // 
            this.ExtensionsTab.BackColor = System.Drawing.Color.White;
            this.ExtensionsTab.Controls.Add(this.EMiddleGlowPnl);
            this.ExtensionsTab.Controls.Add(this.EExtensionLogoPctbx);
            this.ExtensionsTab.Controls.Add(this.ETopGlowPnl);
            this.ExtensionsTab.Controls.Add(this.ETanjiExtensionViewer);
            this.ExtensionsTab.Location = new System.Drawing.Point(4, 28);
            this.ExtensionsTab.Name = "ExtensionsTab";
            this.ExtensionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExtensionsTab.Size = new System.Drawing.Size(471, 313);
            this.ExtensionsTab.TabIndex = 5;
            this.ExtensionsTab.Text = "Extensions";
            // 
            // EMiddleGlowPnl
            // 
            this.EMiddleGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EMiddleGlowPnl.Location = new System.Drawing.Point(76, 243);
            this.EMiddleGlowPnl.Name = "EMiddleGlowPnl";
            this.EMiddleGlowPnl.Size = new System.Drawing.Size(1, 64);
            this.EMiddleGlowPnl.TabIndex = 2;
            // 
            // EExtensionLogoPctbx
            // 
            this.EExtensionLogoPctbx.ErrorImage = null;
            this.EExtensionLogoPctbx.Image = global::Tanji.Properties.Resources.Tanji;
            this.EExtensionLogoPctbx.InitialImage = null;
            this.EExtensionLogoPctbx.Location = new System.Drawing.Point(6, 243);
            this.EExtensionLogoPctbx.Name = "EExtensionLogoPctbx";
            this.EExtensionLogoPctbx.Size = new System.Drawing.Size(64, 64);
            this.EExtensionLogoPctbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EExtensionLogoPctbx.TabIndex = 2;
            this.EExtensionLogoPctbx.TabStop = false;
            // 
            // ETopGlowPnl
            // 
            this.ETopGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ETopGlowPnl.Location = new System.Drawing.Point(0, 236);
            this.ETopGlowPnl.Name = "ETopGlowPnl";
            this.ETopGlowPnl.Size = new System.Drawing.Size(471, 1);
            this.ETopGlowPnl.TabIndex = 1;
            // 
            // ETanjiExtensionViewer
            // 
            this.ETanjiExtensionViewer.AllowDrop = true;
            this.ETanjiExtensionViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.AuthorCol,
            this.EVersionCol});
            this.ETanjiExtensionViewer.ContextMenuStrip = this.EExtensionMenu;
            this.ETanjiExtensionViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ETanjiExtensionViewer.FullRowSelect = true;
            this.ETanjiExtensionViewer.GridLines = true;
            this.ETanjiExtensionViewer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ETanjiExtensionViewer.HideSelection = false;
            this.ETanjiExtensionViewer.Location = new System.Drawing.Point(3, 3);
            this.ETanjiExtensionViewer.MultiSelect = false;
            this.ETanjiExtensionViewer.Name = "ETanjiExtensionViewer";
            this.ETanjiExtensionViewer.ShowItemToolTips = true;
            this.ETanjiExtensionViewer.Size = new System.Drawing.Size(465, 227);
            this.ETanjiExtensionViewer.TabIndex = 0;
            this.ETanjiExtensionViewer.UseCompatibleStateImageBehavior = false;
            this.ETanjiExtensionViewer.View = System.Windows.Forms.View.Details;
            this.ETanjiExtensionViewer.ItemActivate += new System.EventHandler(this.ETanjiExtensionViewer_ItemActivate);
            this.ETanjiExtensionViewer.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ETanjiExtensionViewer_ItemSelectionChanged);
            this.ETanjiExtensionViewer.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExtensionViewer_DragDrop);
            this.ETanjiExtensionViewer.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExtensionViewer_DragEnter);
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 140;
            // 
            // AuthorCol
            // 
            this.AuthorCol.Text = "Author";
            this.AuthorCol.Width = 110;
            // 
            // EVersionCol
            // 
            this.EVersionCol.Text = "Version";
            this.EVersionCol.Width = 101;
            // 
            // OptionsTab
            // 
            this.OptionsTab.BackColor = System.Drawing.Color.White;
            this.OptionsTab.Controls.Add(this.OOptionsTab);
            this.OptionsTab.Location = new System.Drawing.Point(4, 28);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTab.Size = new System.Drawing.Size(471, 313);
            this.OptionsTab.TabIndex = 4;
            this.OptionsTab.Text = "Options";
            // 
            // OOptionsTab
            // 
            this.OOptionsTab.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.OOptionsTab.Controls.Add(this.OSettingsTab);
            this.OOptionsTab.Controls.Add(this.OAboutTab);
            this.OOptionsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OOptionsTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.OOptionsTab.ItemSize = new System.Drawing.Size(47, 24);
            this.OOptionsTab.Location = new System.Drawing.Point(3, 3);
            this.OOptionsTab.Multiline = true;
            this.OOptionsTab.Name = "OOptionsTab";
            this.OOptionsTab.SelectedIndex = 0;
            this.OOptionsTab.Size = new System.Drawing.Size(465, 307);
            this.OOptionsTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.OOptionsTab.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.OOptionsTab.TabIndex = 0;
            // 
            // OSettingsTab
            // 
            this.OSettingsTab.BackColor = System.Drawing.Color.White;
            this.OSettingsTab.Controls.Add(this.OSAlwaysOnTopChckbx);
            this.OSettingsTab.Controls.Add(this.OSScreenEdgeSnappingChckbx);
            this.OSettingsTab.Controls.Add(this.OSCloseOnDisconnectChckbx);
            this.OSettingsTab.Location = new System.Drawing.Point(4, 4);
            this.OSettingsTab.Name = "OSettingsTab";
            this.OSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OSettingsTab.Size = new System.Drawing.Size(410, 299);
            this.OSettingsTab.TabIndex = 1;
            this.OSettingsTab.Text = "Settings";
            // 
            // OSAlwaysOnTopChckbx
            // 
            this.OSAlwaysOnTopChckbx.AutoSize = true;
            this.OSAlwaysOnTopChckbx.Location = new System.Drawing.Point(6, 6);
            this.OSAlwaysOnTopChckbx.Name = "OSAlwaysOnTopChckbx";
            this.OSAlwaysOnTopChckbx.Size = new System.Drawing.Size(98, 17);
            this.OSAlwaysOnTopChckbx.TabIndex = 4;
            this.OSAlwaysOnTopChckbx.Text = "Always On Top";
            this.OSAlwaysOnTopChckbx.UseVisualStyleBackColor = true;
            this.OSAlwaysOnTopChckbx.CheckedChanged += new System.EventHandler(this.OSAlwaysOnTopChckbx_CheckedChanged);
            // 
            // OSScreenEdgeSnappingChckbx
            // 
            this.OSScreenEdgeSnappingChckbx.AutoSize = true;
            this.OSScreenEdgeSnappingChckbx.Checked = true;
            this.OSScreenEdgeSnappingChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OSScreenEdgeSnappingChckbx.Location = new System.Drawing.Point(6, 29);
            this.OSScreenEdgeSnappingChckbx.Name = "OSScreenEdgeSnappingChckbx";
            this.OSScreenEdgeSnappingChckbx.Size = new System.Drawing.Size(136, 17);
            this.OSScreenEdgeSnappingChckbx.TabIndex = 2;
            this.OSScreenEdgeSnappingChckbx.Text = "Screen Edge Snapping";
            this.OSScreenEdgeSnappingChckbx.UseVisualStyleBackColor = true;
            this.OSScreenEdgeSnappingChckbx.CheckedChanged += new System.EventHandler(this.OSScreenEdgeSnappingChckbx_CheckedChanged);
            // 
            // OSCloseOnDisconnectChckbx
            // 
            this.OSCloseOnDisconnectChckbx.AutoSize = true;
            this.OSCloseOnDisconnectChckbx.Location = new System.Drawing.Point(6, 52);
            this.OSCloseOnDisconnectChckbx.Name = "OSCloseOnDisconnectChckbx";
            this.OSCloseOnDisconnectChckbx.Size = new System.Drawing.Size(146, 17);
            this.OSCloseOnDisconnectChckbx.TabIndex = 1;
            this.OSCloseOnDisconnectChckbx.Text = "Close After Disconnected";
            this.OSCloseOnDisconnectChckbx.UseVisualStyleBackColor = true;
            this.OSCloseOnDisconnectChckbx.CheckedChanged += new System.EventHandler(this.OSCloseOnDisconnectChckbx_CheckedChanged);
            // 
            // OAboutTab
            // 
            this.OAboutTab.BackColor = System.Drawing.Color.White;
            this.OAboutTab.Location = new System.Drawing.Point(4, 4);
            this.OAboutTab.Name = "OAboutTab";
            this.OAboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.OAboutTab.Size = new System.Drawing.Size(410, 299);
            this.OAboutTab.TabIndex = 0;
            this.OAboutTab.Text = "About";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 369);
            this.Controls.Add(this.TanjiTabs);
            this.Controls.Add(this.TanjiStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji  ~ Connected[Host:Port]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.EExtensionMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).EndInit();
            this.ICConstructMenu.ResumeLayout(false);
            this.TanjiTabs.ResumeLayout(false);
            this.InjectionTab.ResumeLayout(false);
            this.InjectionTab.PerformLayout();
            this.IInjectionTabs.ResumeLayout(false);
            this.IConstructerTab.ResumeLayout(false);
            this.IConstructerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICCountTxt)).EndInit();
            this.ISchedulerTab.ResumeLayout(false);
            this.ISchedulerTab.PerformLayout();
            this.IPrimitiveTab.ResumeLayout(false);
            this.IPrimitiveTab.PerformLayout();
            this.IFiltersTab.ResumeLayout(false);
            this.IFFilterTabs.ResumeLayout(false);
            this.EncoderDecoderTab.ResumeLayout(false);
            this.ModernEncodingGrpbx.ResumeLayout(false);
            this.ModernEncodingGrpbx.PerformLayout();
            this.ExtensionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EExtensionLogoPctbx)).EndInit();
            this.OptionsTab.ResumeLayout(false);
            this.OOptionsTab.ResumeLayout(false);
            this.OSettingsTab.ResumeLayout(false);
            this.OSettingsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip TanjiStrip;
        private System.Windows.Forms.ToolStripStatusLabel SchedulesTxt;
        private System.Windows.Forms.TabPage EncoderDecoderTab;
        private System.Windows.Forms.TabPage InjectionTab;
        private Sulakore.Components.SKoreTabControl TanjiTabs;
        private System.Windows.Forms.TabPage ToolboxTab;
        private System.Windows.Forms.TabPage OptionsTab;
        private Sulakore.Components.SKoreTabControl IInjectionTabs;
        private System.Windows.Forms.TabPage IPrimitiveTab;
        private System.Windows.Forms.TabPage IConstructerTab;
        private System.Windows.Forms.TextBox IPacketTxt;
        private Sulakore.Components.SKoreButton ISendToClientBtn;
        private Sulakore.Components.SKoreButton ISendToServerBtn;
        private System.Windows.Forms.TabPage ISchedulerTab;
        private System.Windows.Forms.TabPage ITriggersTab;
        private System.Windows.Forms.TabPage IFiltersTab;
        private System.Windows.Forms.ToolStripStatusLabel ExtensionsActiveTxt;
        private System.Windows.Forms.GroupBox ModernEncodingGrpbx;
        private System.Windows.Forms.TextBox ModernShortOutputTxt;
        private System.Windows.Forms.TextBox ModernIntegerOutputTxt;
        private System.Windows.Forms.TextBox ModernShortInputTxt;
        private Sulakore.Components.SKoreButton ModernCypherShortBtn;
        private Sulakore.Components.SKoreButton ModernCypherIntegerBtn;
        private Sulakore.Components.SKoreButton ModernDecypherShortBtn;
        private Sulakore.Components.SKoreButton ModernDecypherIntegerBtn;
        private System.Windows.Forms.TextBox ModernIntegerInputTxt;
        private System.Windows.Forms.TabPage ExtensionsTab;
        private Sulakore.Components.SKoreConstructer ICConstructerLstVw;
        private System.Windows.Forms.Label ICHeaderLbl;
        private System.Windows.Forms.TextBox ICHeaderTxt;
        private System.Windows.Forms.Label ICValueLbl;
        private System.Windows.Forms.TextBox ICValueTxt;
        private Sulakore.Components.SKoreButton ICAppendBooleanBtn;
        private Sulakore.Components.SKoreButton ICAppendStringBtn;
        private Sulakore.Components.SKoreButton ICAppendIntegerBtn;
        private Sulakore.Components.SKoreButton ICClearBtn;
        private Sulakore.Components.SKoreButton ICRemoveBtn;
        private Sulakore.Components.SKoreButton ICMoveDownBtn;
        private Sulakore.Components.SKoreButton ICMoveUpBtn;
        private System.Windows.Forms.ContextMenuStrip EExtensionMenu;
        private System.Windows.Forms.ToolStripMenuItem EOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem EUninstallBtn;
        private System.Windows.Forms.ToolStripSeparator EExtensionsSeperator;
        private System.Windows.Forms.ToolStripMenuItem EInstallExtensionBtn;
        private System.Windows.Forms.Label ISBurstLbl;
        private System.Windows.Forms.NumericUpDown ISBurstTxt;
        private System.Windows.Forms.Label ISIntervalLbl;
        private System.Windows.Forms.NumericUpDown ISIntervalTxt;
        private System.Windows.Forms.Label ISDestinationLbl;
        private System.Windows.Forms.ComboBox ISDestinationTxt;
        private System.Windows.Forms.Label ISPacketLbl;
        private System.Windows.Forms.TextBox ISPacketTxt;
        private System.Windows.Forms.Label ISDescriptionLbl;
        private System.Windows.Forms.TextBox ISDescriptionTxt;
        private Sulakore.Components.SKoreButton ISStartAllBtn;
        private Sulakore.Components.SKoreButton ISStopAllBtn;
        private Sulakore.Components.SKoreButton ISRemoveBtn;
        private Sulakore.Components.SKoreButton ISCreateBtn;
        private Sulakore.Components.SKoreScheduler ISSchedulesLstVw;
        private System.Windows.Forms.OpenFileDialog ChooseExtensionDlg;
        private System.Windows.Forms.Label ICCountLbl;
        private System.Windows.Forms.NumericUpDown ICCountTxt;
        private System.Windows.Forms.TextBox IPPacketTxt;
        private System.Windows.Forms.Label IPPacketInfoLbl;
        private System.Windows.Forms.Label IPIsCorruptedLbl;
        private System.Windows.Forms.CheckBox ISAutoStartChckbx;
        private Sulakore.Components.SKoreExtensionView ETanjiExtensionViewer;
        private Sulakore.Components.SKoreTabControl OOptionsTab;
        private System.Windows.Forms.TabPage OAboutTab;
        private System.Windows.Forms.ToolTip TanjiTip;
        private System.Windows.Forms.TabPage OSettingsTab;
        private System.Windows.Forms.CheckBox OSScreenEdgeSnappingChckbx;
        private System.Windows.Forms.CheckBox OSCloseOnDisconnectChckbx;
        private System.Windows.Forms.ToolStripStatusLabel VersionTxt;
        private System.Windows.Forms.CheckBox OSAlwaysOnTopChckbx;
        private Sulakore.Components.SKoreTabControl IFFilterTabs;
        private System.Windows.Forms.Panel ETopGlowPnl;
        private System.Windows.Forms.PictureBox EExtensionLogoPctbx;
        private System.Windows.Forms.Panel EMiddleGlowPnl;
        private System.Windows.Forms.ColumnHeader ICTypeCol;
        private System.Windows.Forms.ColumnHeader ICValueCol;
        private System.Windows.Forms.ColumnHeader ICEncodedCol;
        private System.Windows.Forms.Label ICChunkCountLbl;
        private System.Windows.Forms.Panel ICChunksLeftGlowPnl;
        private System.Windows.Forms.Panel ICChunksRightGlowPnl;
        private System.Windows.Forms.ContextMenuStrip ICConstructMenu;
        private System.Windows.Forms.ToolStripMenuItem ICCopyPacketBtn;
        private System.Windows.Forms.ToolStripMenuItem ICTransferToBtn;
        private System.Windows.Forms.ToolStripMenuItem ICSchedulerBtn;
        private System.Windows.Forms.ToolStripMenuItem ICPrimitiveBtn;
        private System.Windows.Forms.ColumnHeader ISPacketCol;
        private System.Windows.Forms.ColumnHeader ISDestinationCol;
        private System.Windows.Forms.ColumnHeader ISBurstCol;
        private System.Windows.Forms.ColumnHeader ISIntervalCol;
        private System.Windows.Forms.ColumnHeader ISStatusCol;
        private Sulakore.Components.SKoreButton ISClearBtn;
        private System.Windows.Forms.ToolStripSeparator ICTransferSeparator;
        private System.Windows.Forms.ToolStripMenuItem ICInjectionBtn;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader AuthorCol;
        private System.Windows.Forms.ColumnHeader EVersionCol;
        private System.Windows.Forms.TabPage IFReplaceTab;
        private System.Windows.Forms.TabPage IFBlockTab;
        private System.Windows.Forms.ToolStripStatusLabel TanjiInfoTxt;

    }
}

