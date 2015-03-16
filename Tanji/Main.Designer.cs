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
            this.ISSchedulerLstvw = new Sulakore.Components.SKoreScheduler();
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
            this.ICConstructerLstvw = new Sulakore.Components.SKoreConstructer();
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
            this.IPPrimitiveTxt = new System.Windows.Forms.TextBox();
            this.ITriggersTab = new System.Windows.Forms.TabPage();
            this.IFiltersTab = new System.Windows.Forms.TabPage();
            this.IFFilterModeTabs = new Sulakore.Components.SKoreTabControl();
            this.IFBlockTab = new System.Windows.Forms.TabPage();
            this.IFBDestinationLbl = new System.Windows.Forms.Label();
            this.IFBDestinationTxt = new System.Windows.Forms.ComboBox();
            this.IFBHeaderTxt = new System.Windows.Forms.TextBox();
            this.IFBHeaderLbl = new System.Windows.Forms.Label();
            this.IFBUnblockBtn = new Sulakore.Components.SKoreButton();
            this.IFBBlockBtn = new Sulakore.Components.SKoreButton();
            this.IFBBlockLstvw = new Sulakore.Components.SKoreListView();
            this.BDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BHeaderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BPublisherCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IFReplaceTab = new System.Windows.Forms.TabPage();
            this.IFRDestinationLbl = new System.Windows.Forms.Label();
            this.IFRDestinationTxt = new System.Windows.Forms.ComboBox();
            this.IFRHeaderTxt = new System.Windows.Forms.TextBox();
            this.IFRHeaderLbl = new System.Windows.Forms.Label();
            this.IFRUnreplaceBtn = new Sulakore.Components.SKoreButton();
            this.IFRReplaceBtn = new Sulakore.Components.SKoreButton();
            this.IFRReplacementTxt = new System.Windows.Forms.TextBox();
            this.IFReplacementLbl = new System.Windows.Forms.Label();
            this.IFRReplaceLstvw = new Sulakore.Components.SKoreListView();
            this.RDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RHeaderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RReplacementCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EncoderDecoderTab = new System.Windows.Forms.TabPage();
            this.EDExtracterLstvw = new Sulakore.Components.SKoreListView();
            this.ValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PositionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EDExtractValuesBtn = new Sulakore.Components.SKoreButton();
            this.EDEncodedBlocksLbl = new System.Windows.Forms.Label();
            this.EDEncodedBlocksTxt = new System.Windows.Forms.TextBox();
            this.EDMiddleGlowPnl = new System.Windows.Forms.Panel();
            this.EDShortOutputTxt = new System.Windows.Forms.TextBox();
            this.EDIntegerOutputTxt = new System.Windows.Forms.TextBox();
            this.EDShortInputTxt = new System.Windows.Forms.TextBox();
            this.EDEncodeShortBtn = new Sulakore.Components.SKoreButton();
            this.EDEncodeIntegerBtn = new Sulakore.Components.SKoreButton();
            this.EDDecodeShortBtn = new Sulakore.Components.SKoreButton();
            this.EDDecodeIntegerBtn = new Sulakore.Components.SKoreButton();
            this.EDIntegerInputTxt = new System.Windows.Forms.TextBox();
            this.ToolboxTab = new System.Windows.Forms.TabPage();
            this.TRequestLbl = new System.Windows.Forms.LinkLabel();
            this.TSuggestLbl = new System.Windows.Forms.Label();
            this.ExtensionsTab = new System.Windows.Forms.TabPage();
            this.EMiddleGlowPnl = new System.Windows.Forms.Panel();
            this.EExtensionLogoPctbx = new System.Windows.Forms.PictureBox();
            this.ETopGlowPnl = new System.Windows.Forms.Panel();
            this.EExtensionsLstvw = new Sulakore.Components.SKoreExtensionView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EVersionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.OOptionsTab = new Sulakore.Components.SKoreTabControl();
            this.OSettingsTab = new System.Windows.Forms.TabPage();
            this.OSAlwaysOnTopChckbx = new System.Windows.Forms.CheckBox();
            this.OSCloseOnDisconnectChckbx = new System.Windows.Forms.CheckBox();
            this.OAboutTab = new System.Windows.Forms.TabPage();
            this.ITSavedTriggers = new System.Windows.Forms.ComboBox();
            this.sKoreButton1 = new Sulakore.Components.SKoreButton();
            this.sKoreListView1 = new Sulakore.Components.SKoreListView();
            this.ITTypePropertyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ITPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ITPredicate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ITCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ITNotDoneLbl = new System.Windows.Forms.Label();
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
            this.ITriggersTab.SuspendLayout();
            this.IFiltersTab.SuspendLayout();
            this.IFFilterModeTabs.SuspendLayout();
            this.IFBlockTab.SuspendLayout();
            this.IFReplaceTab.SuspendLayout();
            this.EncoderDecoderTab.SuspendLayout();
            this.ToolboxTab.SuspendLayout();
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
            this.VersionTxt.IsLink = true;
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
            // ISSchedulerLstvw
            // 
            this.ISSchedulerLstvw.CheckBoxes = true;
            this.ISSchedulerLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISPacketCol,
            this.ISDestinationCol,
            this.ISBurstCol,
            this.ISIntervalCol,
            this.ISStatusCol});
            this.ISSchedulerLstvw.FullRowSelect = true;
            this.ISSchedulerLstvw.GridLines = true;
            this.ISSchedulerLstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ISSchedulerLstvw.HideSelection = false;
            this.ISSchedulerLstvw.Location = new System.Drawing.Point(6, 6);
            this.ISSchedulerLstvw.MultiSelect = false;
            this.ISSchedulerLstvw.Name = "ISSchedulerLstvw";
            this.ISSchedulerLstvw.ShowItemToolTips = true;
            this.ISSchedulerLstvw.Size = new System.Drawing.Size(380, 150);
            this.ISSchedulerLstvw.TabIndex = 41;
            this.TanjiTip.SetToolTip(this.ISSchedulerLstvw, "To toggle, double click the selected schedule.");
            this.ISSchedulerLstvw.UseCompatibleStateImageBehavior = false;
            this.ISSchedulerLstvw.View = System.Windows.Forms.View.Details;
            this.ISSchedulerLstvw.ScheduleTriggered += new System.EventHandler<Sulakore.Protocol.HScheduleTriggeredEventArgs>(this.ISSchedulesLstVw_ScheduleTriggered);
            this.ISSchedulerLstvw.ItemSelected += new System.EventHandler<System.Windows.Forms.ListViewItemSelectionChangedEventArgs>(this.ISSchedulesLstVw_ItemSelected);
            this.ISSchedulerLstvw.ItemsDeselected += new System.EventHandler(this.ISSchedulesLstVw_ItemsDeselected);
            this.ISSchedulerLstvw.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ISSchedulesLstVw_ItemChecked);
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
            this.IConstructerTab.Controls.Add(this.ICConstructerLstvw);
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
            this.ICAppendBooleanBtn.Click += new System.EventHandler(this.ICAppendBtn_Click);
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
            this.ICAppendStringBtn.Click += new System.EventHandler(this.ICAppendBtn_Click);
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
            this.ICAppendIntegerBtn.Click += new System.EventHandler(this.ICAppendBtn_Click);
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
            // ICConstructerLstvw
            // 
            this.ICConstructerLstvw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ICConstructerLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ICTypeCol,
            this.ICValueCol,
            this.ICEncodedCol});
            this.ICConstructerLstvw.ContextMenuStrip = this.ICConstructMenu;
            this.ICConstructerLstvw.FullRowSelect = true;
            this.ICConstructerLstvw.GridLines = true;
            this.ICConstructerLstvw.Header = ((ushort)(0));
            this.ICConstructerLstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ICConstructerLstvw.HideSelection = false;
            this.ICConstructerLstvw.Location = new System.Drawing.Point(6, 73);
            this.ICConstructerLstvw.MultiSelect = false;
            this.ICConstructerLstvw.Name = "ICConstructerLstvw";
            this.ICConstructerLstvw.ShowItemToolTips = true;
            this.ICConstructerLstvw.Size = new System.Drawing.Size(380, 161);
            this.ICConstructerLstvw.TabIndex = 0;
            this.ICConstructerLstvw.UseCompatibleStateImageBehavior = false;
            this.ICConstructerLstvw.View = System.Windows.Forms.View.Details;
            this.ICConstructerLstvw.ItemSelected += new System.EventHandler<System.Windows.Forms.ListViewItemSelectionChangedEventArgs>(this.ICConstructerLstVw_ItemSelected);
            this.ICConstructerLstvw.ItemsDeselected += new System.EventHandler(this.ICConstructerLstVw_ItemsDeselected);
            this.ICConstructerLstvw.ItemActivate += new System.EventHandler(this.ICConstructerLstVw_ItemActivate);
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
            this.ISchedulerTab.Controls.Add(this.ISSchedulerLstvw);
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
            this.IPrimitiveTab.Controls.Add(this.IPPrimitiveTxt);
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
            // IPPrimitiveTxt
            // 
            this.IPPrimitiveTxt.Location = new System.Drawing.Point(6, 19);
            this.IPPrimitiveTxt.MaxLength = 2147483647;
            this.IPPrimitiveTxt.Multiline = true;
            this.IPPrimitiveTxt.Name = "IPPrimitiveTxt";
            this.IPPrimitiveTxt.Size = new System.Drawing.Size(379, 243);
            this.IPPrimitiveTxt.TabIndex = 0;
            this.IPPrimitiveTxt.TextChanged += new System.EventHandler(this.IPPrimitiveTxt_TextChanged);
            // 
            // ITriggersTab
            // 
            this.ITriggersTab.BackColor = System.Drawing.Color.White;
            this.ITriggersTab.Controls.Add(this.ITNotDoneLbl);
            this.ITriggersTab.Controls.Add(this.label1);
            this.ITriggersTab.Controls.Add(this.ITSavedTriggers);
            this.ITriggersTab.Controls.Add(this.sKoreButton1);
            this.ITriggersTab.Controls.Add(this.sKoreListView1);
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
            this.IFiltersTab.Controls.Add(this.IFFilterModeTabs);
            this.IFiltersTab.Location = new System.Drawing.Point(4, 4);
            this.IFiltersTab.Name = "IFiltersTab";
            this.IFiltersTab.Padding = new System.Windows.Forms.Padding(3);
            this.IFiltersTab.Size = new System.Drawing.Size(392, 268);
            this.IFiltersTab.TabIndex = 4;
            this.IFiltersTab.Text = "Filters";
            // 
            // IFFilterModeTabs
            // 
            this.IFFilterModeTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.IFFilterModeTabs.Controls.Add(this.IFBlockTab);
            this.IFFilterModeTabs.Controls.Add(this.IFReplaceTab);
            this.IFFilterModeTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IFFilterModeTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.IFFilterModeTabs.ItemSize = new System.Drawing.Size(48, 24);
            this.IFFilterModeTabs.Location = new System.Drawing.Point(3, 3);
            this.IFFilterModeTabs.Multiline = true;
            this.IFFilterModeTabs.Name = "IFFilterModeTabs";
            this.IFFilterModeTabs.SelectedIndex = 0;
            this.IFFilterModeTabs.Size = new System.Drawing.Size(386, 262);
            this.IFFilterModeTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.IFFilterModeTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IFFilterModeTabs.TabIndex = 0;
            // 
            // IFBlockTab
            // 
            this.IFBlockTab.BackColor = System.Drawing.Color.White;
            this.IFBlockTab.Controls.Add(this.IFBDestinationLbl);
            this.IFBlockTab.Controls.Add(this.IFBDestinationTxt);
            this.IFBlockTab.Controls.Add(this.IFBHeaderTxt);
            this.IFBlockTab.Controls.Add(this.IFBHeaderLbl);
            this.IFBlockTab.Controls.Add(this.IFBUnblockBtn);
            this.IFBlockTab.Controls.Add(this.IFBBlockBtn);
            this.IFBlockTab.Controls.Add(this.IFBBlockLstvw);
            this.IFBlockTab.Location = new System.Drawing.Point(52, 4);
            this.IFBlockTab.Name = "IFBlockTab";
            this.IFBlockTab.Padding = new System.Windows.Forms.Padding(3);
            this.IFBlockTab.Size = new System.Drawing.Size(330, 254);
            this.IFBlockTab.TabIndex = 1;
            this.IFBlockTab.Text = "Block";
            // 
            // IFBDestinationLbl
            // 
            this.IFBDestinationLbl.AutoSize = true;
            this.IFBDestinationLbl.Location = new System.Drawing.Point(76, 3);
            this.IFBDestinationLbl.Name = "IFBDestinationLbl";
            this.IFBDestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.IFBDestinationLbl.TabIndex = 13;
            this.IFBDestinationLbl.Text = "Destination";
            // 
            // IFBDestinationTxt
            // 
            this.IFBDestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IFBDestinationTxt.FormattingEnabled = true;
            this.IFBDestinationTxt.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.IFBDestinationTxt.Location = new System.Drawing.Point(79, 18);
            this.IFBDestinationTxt.Name = "IFBDestinationTxt";
            this.IFBDestinationTxt.Size = new System.Drawing.Size(71, 21);
            this.IFBDestinationTxt.TabIndex = 12;
            // 
            // IFBHeaderTxt
            // 
            this.IFBHeaderTxt.Location = new System.Drawing.Point(6, 19);
            this.IFBHeaderTxt.MaxLength = 4;
            this.IFBHeaderTxt.Name = "IFBHeaderTxt";
            this.IFBHeaderTxt.Size = new System.Drawing.Size(67, 20);
            this.IFBHeaderTxt.TabIndex = 11;
            this.IFBHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IFBHeaderTxt.TextChanged += new System.EventHandler(this.IFHeaderTxt_TextChanged);
            // 
            // IFBHeaderLbl
            // 
            this.IFBHeaderLbl.AutoSize = true;
            this.IFBHeaderLbl.Location = new System.Drawing.Point(3, 3);
            this.IFBHeaderLbl.Name = "IFBHeaderLbl";
            this.IFBHeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.IFBHeaderLbl.TabIndex = 10;
            this.IFBHeaderLbl.Text = "Header";
            // 
            // IFBUnblockBtn
            // 
            this.IFBUnblockBtn.BackColor = System.Drawing.Color.Transparent;
            this.IFBUnblockBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IFBUnblockBtn.Enabled = false;
            this.IFBUnblockBtn.Location = new System.Drawing.Point(243, 17);
            this.IFBUnblockBtn.Name = "IFBUnblockBtn";
            this.IFBUnblockBtn.Size = new System.Drawing.Size(81, 22);
            this.IFBUnblockBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IFBUnblockBtn.TabIndex = 9;
            this.IFBUnblockBtn.Text = "Unblock";
            this.IFBUnblockBtn.Click += new System.EventHandler(this.IFUnblockBtn_Click);
            // 
            // IFBBlockBtn
            // 
            this.IFBBlockBtn.BackColor = System.Drawing.Color.Transparent;
            this.IFBBlockBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IFBBlockBtn.Enabled = false;
            this.IFBBlockBtn.Location = new System.Drawing.Point(156, 17);
            this.IFBBlockBtn.Name = "IFBBlockBtn";
            this.IFBBlockBtn.Size = new System.Drawing.Size(81, 22);
            this.IFBBlockBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IFBBlockBtn.TabIndex = 8;
            this.IFBBlockBtn.Text = "Block";
            this.IFBBlockBtn.Click += new System.EventHandler(this.IFBlockBtn_Click);
            // 
            // IFBBlockLstvw
            // 
            this.IFBBlockLstvw.CheckBoxes = true;
            this.IFBBlockLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BDestinationCol,
            this.BHeaderCol,
            this.BPublisherCol});
            this.IFBBlockLstvw.FullRowSelect = true;
            this.IFBBlockLstvw.GridLines = true;
            this.IFBBlockLstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.IFBBlockLstvw.HideSelection = false;
            this.IFBBlockLstvw.Location = new System.Drawing.Point(6, 45);
            this.IFBBlockLstvw.MultiSelect = false;
            this.IFBBlockLstvw.Name = "IFBBlockLstvw";
            this.IFBBlockLstvw.ShowItemToolTips = true;
            this.IFBBlockLstvw.Size = new System.Drawing.Size(318, 203);
            this.IFBBlockLstvw.TabIndex = 7;
            this.IFBBlockLstvw.UseCompatibleStateImageBehavior = false;
            this.IFBBlockLstvw.View = System.Windows.Forms.View.Details;
            this.IFBBlockLstvw.ItemSelected += new System.EventHandler<System.Windows.Forms.ListViewItemSelectionChangedEventArgs>(this.IFBlockLstvw_ItemSelected);
            this.IFBBlockLstvw.ItemsDeselected += new System.EventHandler(this.IFBlockLstvw_ItemsDeselected);
            this.IFBBlockLstvw.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.IFBlockLstvw_ItemChecked);
            // 
            // BDestinationCol
            // 
            this.BDestinationCol.Text = "Destination";
            this.BDestinationCol.Width = 76;
            // 
            // BHeaderCol
            // 
            this.BHeaderCol.Text = "Header";
            this.BHeaderCol.Width = 65;
            // 
            // BPublisherCol
            // 
            this.BPublisherCol.Text = "Publisher(s)";
            this.BPublisherCol.Width = 156;
            // 
            // IFReplaceTab
            // 
            this.IFReplaceTab.BackColor = System.Drawing.Color.White;
            this.IFReplaceTab.Controls.Add(this.IFRDestinationLbl);
            this.IFReplaceTab.Controls.Add(this.IFRDestinationTxt);
            this.IFReplaceTab.Controls.Add(this.IFRHeaderTxt);
            this.IFReplaceTab.Controls.Add(this.IFRHeaderLbl);
            this.IFReplaceTab.Controls.Add(this.IFRUnreplaceBtn);
            this.IFReplaceTab.Controls.Add(this.IFRReplaceBtn);
            this.IFReplaceTab.Controls.Add(this.IFRReplacementTxt);
            this.IFReplaceTab.Controls.Add(this.IFReplacementLbl);
            this.IFReplaceTab.Controls.Add(this.IFRReplaceLstvw);
            this.IFReplaceTab.Location = new System.Drawing.Point(52, 4);
            this.IFReplaceTab.Name = "IFReplaceTab";
            this.IFReplaceTab.Padding = new System.Windows.Forms.Padding(3);
            this.IFReplaceTab.Size = new System.Drawing.Size(330, 254);
            this.IFReplaceTab.TabIndex = 0;
            this.IFReplaceTab.Text = "Replace";
            // 
            // IFRDestinationLbl
            // 
            this.IFRDestinationLbl.AutoSize = true;
            this.IFRDestinationLbl.Location = new System.Drawing.Point(76, 42);
            this.IFRDestinationLbl.Name = "IFRDestinationLbl";
            this.IFRDestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.IFRDestinationLbl.TabIndex = 19;
            this.IFRDestinationLbl.Text = "Destination";
            // 
            // IFRDestinationTxt
            // 
            this.IFRDestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IFRDestinationTxt.FormattingEnabled = true;
            this.IFRDestinationTxt.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.IFRDestinationTxt.Location = new System.Drawing.Point(79, 57);
            this.IFRDestinationTxt.Name = "IFRDestinationTxt";
            this.IFRDestinationTxt.Size = new System.Drawing.Size(71, 21);
            this.IFRDestinationTxt.TabIndex = 18;
            // 
            // IFRHeaderTxt
            // 
            this.IFRHeaderTxt.Location = new System.Drawing.Point(6, 58);
            this.IFRHeaderTxt.MaxLength = 4;
            this.IFRHeaderTxt.Name = "IFRHeaderTxt";
            this.IFRHeaderTxt.Size = new System.Drawing.Size(67, 20);
            this.IFRHeaderTxt.TabIndex = 17;
            this.IFRHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IFRHeaderTxt.TextChanged += new System.EventHandler(this.IFRHeaderTxt_TextChanged);
            // 
            // IFRHeaderLbl
            // 
            this.IFRHeaderLbl.AutoSize = true;
            this.IFRHeaderLbl.Location = new System.Drawing.Point(3, 42);
            this.IFRHeaderLbl.Name = "IFRHeaderLbl";
            this.IFRHeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.IFRHeaderLbl.TabIndex = 16;
            this.IFRHeaderLbl.Text = "Header";
            // 
            // IFRUnreplaceBtn
            // 
            this.IFRUnreplaceBtn.BackColor = System.Drawing.Color.Transparent;
            this.IFRUnreplaceBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IFRUnreplaceBtn.Enabled = false;
            this.IFRUnreplaceBtn.Location = new System.Drawing.Point(243, 56);
            this.IFRUnreplaceBtn.Name = "IFRUnreplaceBtn";
            this.IFRUnreplaceBtn.Size = new System.Drawing.Size(81, 22);
            this.IFRUnreplaceBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IFRUnreplaceBtn.TabIndex = 15;
            this.IFRUnreplaceBtn.Text = "Unreplace";
            this.IFRUnreplaceBtn.Click += new System.EventHandler(this.IFRUnreplaceBtn_Click);
            // 
            // IFRReplaceBtn
            // 
            this.IFRReplaceBtn.BackColor = System.Drawing.Color.Transparent;
            this.IFRReplaceBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IFRReplaceBtn.Enabled = false;
            this.IFRReplaceBtn.Location = new System.Drawing.Point(156, 56);
            this.IFRReplaceBtn.Name = "IFRReplaceBtn";
            this.IFRReplaceBtn.Size = new System.Drawing.Size(81, 22);
            this.IFRReplaceBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IFRReplaceBtn.TabIndex = 14;
            this.IFRReplaceBtn.Text = "Replace";
            this.IFRReplaceBtn.Click += new System.EventHandler(this.IFRReplaceBtn_Click);
            // 
            // IFRReplacementTxt
            // 
            this.IFRReplacementTxt.Location = new System.Drawing.Point(6, 19);
            this.IFRReplacementTxt.Name = "IFRReplacementTxt";
            this.IFRReplacementTxt.Size = new System.Drawing.Size(318, 20);
            this.IFRReplacementTxt.TabIndex = 10;
            this.IFRReplacementTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IFRReplacementTxt.TextChanged += new System.EventHandler(this.IFRReplacementTxt_TextChanged);
            // 
            // IFReplacementLbl
            // 
            this.IFReplacementLbl.AutoSize = true;
            this.IFReplacementLbl.Location = new System.Drawing.Point(3, 3);
            this.IFReplacementLbl.Name = "IFReplacementLbl";
            this.IFReplacementLbl.Size = new System.Drawing.Size(70, 13);
            this.IFReplacementLbl.TabIndex = 9;
            this.IFReplacementLbl.Text = "Replacement";
            // 
            // IFRReplaceLstvw
            // 
            this.IFRReplaceLstvw.CheckBoxes = true;
            this.IFRReplaceLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RDestinationCol,
            this.RHeaderCol,
            this.RReplacementCol});
            this.IFRReplaceLstvw.FullRowSelect = true;
            this.IFRReplaceLstvw.GridLines = true;
            this.IFRReplaceLstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.IFRReplaceLstvw.HideSelection = false;
            this.IFRReplaceLstvw.Location = new System.Drawing.Point(6, 84);
            this.IFRReplaceLstvw.MultiSelect = false;
            this.IFRReplaceLstvw.Name = "IFRReplaceLstvw";
            this.IFRReplaceLstvw.ShowItemToolTips = true;
            this.IFRReplaceLstvw.Size = new System.Drawing.Size(318, 164);
            this.IFRReplaceLstvw.TabIndex = 8;
            this.IFRReplaceLstvw.UseCompatibleStateImageBehavior = false;
            this.IFRReplaceLstvw.View = System.Windows.Forms.View.Details;
            this.IFRReplaceLstvw.ItemSelected += new System.EventHandler<System.Windows.Forms.ListViewItemSelectionChangedEventArgs>(this.IFRReplaceLstvw_ItemSelected);
            this.IFRReplaceLstvw.ItemsDeselected += new System.EventHandler(this.IFRReplaceLstvw_ItemsDeselected);
            this.IFRReplaceLstvw.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.IFRReplaceLstvw_ItemChecked);
            // 
            // RDestinationCol
            // 
            this.RDestinationCol.Text = "Destination";
            this.RDestinationCol.Width = 76;
            // 
            // RHeaderCol
            // 
            this.RHeaderCol.Text = "Header";
            this.RHeaderCol.Width = 65;
            // 
            // RReplacementCol
            // 
            this.RReplacementCol.Text = "Replacement";
            this.RReplacementCol.Width = 156;
            // 
            // EncoderDecoderTab
            // 
            this.EncoderDecoderTab.BackColor = System.Drawing.Color.White;
            this.EncoderDecoderTab.Controls.Add(this.EDExtracterLstvw);
            this.EncoderDecoderTab.Controls.Add(this.EDExtractValuesBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDEncodedBlocksLbl);
            this.EncoderDecoderTab.Controls.Add(this.EDEncodedBlocksTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDMiddleGlowPnl);
            this.EncoderDecoderTab.Controls.Add(this.EDShortOutputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDIntegerOutputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDShortInputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDEncodeShortBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDEncodeIntegerBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDDecodeShortBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDDecodeIntegerBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDIntegerInputTxt);
            this.EncoderDecoderTab.Location = new System.Drawing.Point(4, 28);
            this.EncoderDecoderTab.Name = "EncoderDecoderTab";
            this.EncoderDecoderTab.Padding = new System.Windows.Forms.Padding(3);
            this.EncoderDecoderTab.Size = new System.Drawing.Size(471, 313);
            this.EncoderDecoderTab.TabIndex = 1;
            this.EncoderDecoderTab.Text = "Encoder/Decoder";
            // 
            // EDExtracterLstvw
            // 
            this.EDExtracterLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValueCol,
            this.EncodedCol,
            this.PositionCol});
            this.EDExtracterLstvw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EDExtracterLstvw.FullRowSelect = true;
            this.EDExtracterLstvw.GridLines = true;
            this.EDExtracterLstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EDExtracterLstvw.HideSelection = false;
            this.EDExtracterLstvw.Location = new System.Drawing.Point(3, 99);
            this.EDExtracterLstvw.MultiSelect = false;
            this.EDExtracterLstvw.Name = "EDExtracterLstvw";
            this.EDExtracterLstvw.ShowItemToolTips = true;
            this.EDExtracterLstvw.Size = new System.Drawing.Size(465, 211);
            this.EDExtracterLstvw.TabIndex = 30;
            this.EDExtracterLstvw.UseCompatibleStateImageBehavior = false;
            this.EDExtracterLstvw.View = System.Windows.Forms.View.Details;
            // 
            // ValueCol
            // 
            this.ValueCol.Text = "Value";
            this.ValueCol.Width = 84;
            // 
            // EncodedCol
            // 
            this.EncodedCol.Text = "Encoded";
            this.EncodedCol.Width = 109;
            // 
            // PositionCol
            // 
            this.PositionCol.Text = "Position";
            this.PositionCol.Width = 71;
            // 
            // EDExtractValuesBtn
            // 
            this.EDExtractValuesBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDExtractValuesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDExtractValuesBtn.Location = new System.Drawing.Point(365, 71);
            this.EDExtractValuesBtn.Name = "EDExtractValuesBtn";
            this.EDExtractValuesBtn.Size = new System.Drawing.Size(100, 22);
            this.EDExtractValuesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDExtractValuesBtn.TabIndex = 29;
            this.EDExtractValuesBtn.Text = "Extract Values";
            this.EDExtractValuesBtn.Click += new System.EventHandler(this.EDExtractValuesBtn_Click);
            // 
            // EDEncodedBlocksLbl
            // 
            this.EDEncodedBlocksLbl.AutoSize = true;
            this.EDEncodedBlocksLbl.Location = new System.Drawing.Point(4, 75);
            this.EDEncodedBlocksLbl.Name = "EDEncodedBlocksLbl";
            this.EDEncodedBlocksLbl.Size = new System.Drawing.Size(94, 13);
            this.EDEncodedBlocksLbl.TabIndex = 27;
            this.EDEncodedBlocksLbl.Text = "Encoded Block(s):";
            // 
            // EDEncodedBlocksTxt
            // 
            this.EDEncodedBlocksTxt.Location = new System.Drawing.Point(98, 72);
            this.EDEncodedBlocksTxt.Name = "EDEncodedBlocksTxt";
            this.EDEncodedBlocksTxt.Size = new System.Drawing.Size(261, 20);
            this.EDEncodedBlocksTxt.TabIndex = 28;
            this.EDEncodedBlocksTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDMiddleGlowPnl
            // 
            this.EDMiddleGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDMiddleGlowPnl.Location = new System.Drawing.Point(6, 64);
            this.EDMiddleGlowPnl.Name = "EDMiddleGlowPnl";
            this.EDMiddleGlowPnl.Size = new System.Drawing.Size(459, 1);
            this.EDMiddleGlowPnl.TabIndex = 26;
            // 
            // EDShortOutputTxt
            // 
            this.EDShortOutputTxt.Location = new System.Drawing.Point(239, 36);
            this.EDShortOutputTxt.Name = "EDShortOutputTxt";
            this.EDShortOutputTxt.Size = new System.Drawing.Size(122, 20);
            this.EDShortOutputTxt.TabIndex = 25;
            this.EDShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDIntegerOutputTxt
            // 
            this.EDIntegerOutputTxt.Location = new System.Drawing.Point(239, 8);
            this.EDIntegerOutputTxt.Name = "EDIntegerOutputTxt";
            this.EDIntegerOutputTxt.Size = new System.Drawing.Size(122, 20);
            this.EDIntegerOutputTxt.TabIndex = 24;
            this.EDIntegerOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDShortInputTxt
            // 
            this.EDShortInputTxt.Location = new System.Drawing.Point(110, 36);
            this.EDShortInputTxt.Name = "EDShortInputTxt";
            this.EDShortInputTxt.Size = new System.Drawing.Size(122, 20);
            this.EDShortInputTxt.TabIndex = 23;
            this.EDShortInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDEncodeShortBtn
            // 
            this.EDEncodeShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDEncodeShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDEncodeShortBtn.Location = new System.Drawing.Point(6, 35);
            this.EDEncodeShortBtn.Name = "EDEncodeShortBtn";
            this.EDEncodeShortBtn.Size = new System.Drawing.Size(98, 23);
            this.EDEncodeShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDEncodeShortBtn.TabIndex = 20;
            this.EDEncodeShortBtn.Text = "Encode Short";
            this.EDEncodeShortBtn.Click += new System.EventHandler(this.EDCypherShortBtn_Click);
            // 
            // EDEncodeIntegerBtn
            // 
            this.EDEncodeIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDEncodeIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDEncodeIntegerBtn.Location = new System.Drawing.Point(6, 6);
            this.EDEncodeIntegerBtn.Name = "EDEncodeIntegerBtn";
            this.EDEncodeIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.EDEncodeIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDEncodeIntegerBtn.TabIndex = 19;
            this.EDEncodeIntegerBtn.Text = "Encode Integer";
            this.EDEncodeIntegerBtn.Click += new System.EventHandler(this.EDCypherIntegerBtn_Click);
            // 
            // EDDecodeShortBtn
            // 
            this.EDDecodeShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDDecodeShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDDecodeShortBtn.Location = new System.Drawing.Point(367, 35);
            this.EDDecodeShortBtn.Name = "EDDecodeShortBtn";
            this.EDDecodeShortBtn.Size = new System.Drawing.Size(98, 23);
            this.EDDecodeShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDDecodeShortBtn.TabIndex = 22;
            this.EDDecodeShortBtn.Text = "Decode Short";
            this.EDDecodeShortBtn.Click += new System.EventHandler(this.EDDecypherShortBtn_Click);
            // 
            // EDDecodeIntegerBtn
            // 
            this.EDDecodeIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDDecodeIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDDecodeIntegerBtn.Location = new System.Drawing.Point(367, 6);
            this.EDDecodeIntegerBtn.Name = "EDDecodeIntegerBtn";
            this.EDDecodeIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.EDDecodeIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDDecodeIntegerBtn.TabIndex = 21;
            this.EDDecodeIntegerBtn.Text = "Decode Integer";
            this.EDDecodeIntegerBtn.Click += new System.EventHandler(this.EDDecypherIntegerBtn_Click);
            // 
            // EDIntegerInputTxt
            // 
            this.EDIntegerInputTxt.Location = new System.Drawing.Point(110, 8);
            this.EDIntegerInputTxt.Name = "EDIntegerInputTxt";
            this.EDIntegerInputTxt.Size = new System.Drawing.Size(122, 20);
            this.EDIntegerInputTxt.TabIndex = 18;
            this.EDIntegerInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToolboxTab
            // 
            this.ToolboxTab.BackColor = System.Drawing.Color.White;
            this.ToolboxTab.Controls.Add(this.TRequestLbl);
            this.ToolboxTab.Controls.Add(this.TSuggestLbl);
            this.ToolboxTab.Location = new System.Drawing.Point(4, 28);
            this.ToolboxTab.Name = "ToolboxTab";
            this.ToolboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.ToolboxTab.Size = new System.Drawing.Size(471, 313);
            this.ToolboxTab.TabIndex = 2;
            this.ToolboxTab.Text = "Toolbox";
            // 
            // TRequestLbl
            // 
            this.TRequestLbl.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.TRequestLbl.AutoSize = true;
            this.TRequestLbl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TRequestLbl.Location = new System.Drawing.Point(164, 70);
            this.TRequestLbl.Name = "TRequestLbl";
            this.TRequestLbl.Size = new System.Drawing.Size(142, 13);
            this.TRequestLbl.TabIndex = 1;
            this.TRequestLbl.TabStop = true;
            this.TRequestLbl.Text = "Click me to submit a request!";
            this.TRequestLbl.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TRequestLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TRequestLbl_LinkClicked);
            // 
            // TSuggestLbl
            // 
            this.TSuggestLbl.AutoSize = true;
            this.TSuggestLbl.Location = new System.Drawing.Point(94, 57);
            this.TSuggestLbl.Name = "TSuggestLbl";
            this.TSuggestLbl.Size = new System.Drawing.Size(282, 13);
            this.TSuggestLbl.TabIndex = 0;
            this.TSuggestLbl.Text = "Have any ideas for a \'tool\' that you would like to see here?";
            // 
            // ExtensionsTab
            // 
            this.ExtensionsTab.BackColor = System.Drawing.Color.White;
            this.ExtensionsTab.Controls.Add(this.EMiddleGlowPnl);
            this.ExtensionsTab.Controls.Add(this.EExtensionLogoPctbx);
            this.ExtensionsTab.Controls.Add(this.ETopGlowPnl);
            this.ExtensionsTab.Controls.Add(this.EExtensionsLstvw);
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
            // EExtensionsLstvw
            // 
            this.EExtensionsLstvw.AllowDrop = true;
            this.EExtensionsLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.AuthorCol,
            this.EVersionCol});
            this.EExtensionsLstvw.ContextMenuStrip = this.EExtensionMenu;
            this.EExtensionsLstvw.Dock = System.Windows.Forms.DockStyle.Top;
            this.EExtensionsLstvw.FullRowSelect = true;
            this.EExtensionsLstvw.GridLines = true;
            this.EExtensionsLstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EExtensionsLstvw.HideSelection = false;
            this.EExtensionsLstvw.Location = new System.Drawing.Point(3, 3);
            this.EExtensionsLstvw.MultiSelect = false;
            this.EExtensionsLstvw.Name = "EExtensionsLstvw";
            this.EExtensionsLstvw.ShowItemToolTips = true;
            this.EExtensionsLstvw.Size = new System.Drawing.Size(465, 227);
            this.EExtensionsLstvw.TabIndex = 0;
            this.EExtensionsLstvw.UseCompatibleStateImageBehavior = false;
            this.EExtensionsLstvw.View = System.Windows.Forms.View.Details;
            this.EExtensionsLstvw.ItemActivate += new System.EventHandler(this.ETanjiExtensionViewer_ItemActivate);
            this.EExtensionsLstvw.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ETanjiExtensionViewer_ItemSelectionChanged);
            this.EExtensionsLstvw.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExtensionViewer_DragDrop);
            this.EExtensionsLstvw.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExtensionViewer_DragEnter);
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
            // OSCloseOnDisconnectChckbx
            // 
            this.OSCloseOnDisconnectChckbx.AutoSize = true;
            this.OSCloseOnDisconnectChckbx.Location = new System.Drawing.Point(6, 29);
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
            // ITSavedTriggers
            // 
            this.ITSavedTriggers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ITSavedTriggers.Enabled = false;
            this.ITSavedTriggers.FormattingEnabled = true;
            this.ITSavedTriggers.Location = new System.Drawing.Point(6, 19);
            this.ITSavedTriggers.Name = "ITSavedTriggers";
            this.ITSavedTriggers.Size = new System.Drawing.Size(283, 21);
            this.ITSavedTriggers.TabIndex = 0;
            // 
            // sKoreButton1
            // 
            this.sKoreButton1.BackColor = System.Drawing.Color.Transparent;
            this.sKoreButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sKoreButton1.Enabled = false;
            this.sKoreButton1.Location = new System.Drawing.Point(295, 18);
            this.sKoreButton1.Name = "sKoreButton1";
            this.sKoreButton1.Size = new System.Drawing.Size(91, 22);
            this.sKoreButton1.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sKoreButton1.TabIndex = 3;
            this.sKoreButton1.Text = "Remove";
            // 
            // sKoreListView1
            // 
            this.sKoreListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ITTypePropertyCol,
            this.ITPosition,
            this.ITPredicate,
            this.ITCondition});
            this.sKoreListView1.FullRowSelect = true;
            this.sKoreListView1.GridLines = true;
            this.sKoreListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.sKoreListView1.HideSelection = false;
            this.sKoreListView1.Location = new System.Drawing.Point(6, 46);
            this.sKoreListView1.MultiSelect = false;
            this.sKoreListView1.Name = "sKoreListView1";
            this.sKoreListView1.ShowItemToolTips = true;
            this.sKoreListView1.Size = new System.Drawing.Size(380, 129);
            this.sKoreListView1.TabIndex = 3;
            this.sKoreListView1.UseCompatibleStateImageBehavior = false;
            this.sKoreListView1.View = System.Windows.Forms.View.Details;
            // 
            // ITTypePropertyCol
            // 
            this.ITTypePropertyCol.Text = "Type/Property";
            this.ITTypePropertyCol.Width = 121;
            // 
            // ITPosition
            // 
            this.ITPosition.Text = "Position";
            this.ITPosition.Width = 61;
            // 
            // ITPredicate
            // 
            this.ITPredicate.Text = "Predicate";
            this.ITPredicate.Width = 76;
            // 
            // ITCondition
            // 
            this.ITCondition.Text = "Condition";
            this.ITCondition.Width = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Active Triggers - Total: 0";
            // 
            // ITNotDoneLbl
            // 
            this.ITNotDoneLbl.AutoSize = true;
            this.ITNotDoneLbl.Location = new System.Drawing.Point(82, 200);
            this.ITNotDoneLbl.Name = "ITNotDoneLbl";
            this.ITNotDoneLbl.Size = new System.Drawing.Size(229, 39);
            this.ITNotDoneLbl.TabIndex = 5;
            this.ITNotDoneLbl.Text = "Hey man, I\'m not done here, sorry.\r\nEnjoy the partially finished UI concept thoug" +
    "h...\r\nAtleast I finished the filters, sorta.";
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
            this.ITriggersTab.ResumeLayout(false);
            this.ITriggersTab.PerformLayout();
            this.IFiltersTab.ResumeLayout(false);
            this.IFFilterModeTabs.ResumeLayout(false);
            this.IFBlockTab.ResumeLayout(false);
            this.IFBlockTab.PerformLayout();
            this.IFReplaceTab.ResumeLayout(false);
            this.IFReplaceTab.PerformLayout();
            this.EncoderDecoderTab.ResumeLayout(false);
            this.EncoderDecoderTab.PerformLayout();
            this.ToolboxTab.ResumeLayout(false);
            this.ToolboxTab.PerformLayout();
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
        private System.Windows.Forms.TabPage ExtensionsTab;
        private Sulakore.Components.SKoreConstructer ICConstructerLstvw;
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
        private Sulakore.Components.SKoreScheduler ISSchedulerLstvw;
        private System.Windows.Forms.OpenFileDialog ChooseExtensionDlg;
        private System.Windows.Forms.Label ICCountLbl;
        private System.Windows.Forms.NumericUpDown ICCountTxt;
        private System.Windows.Forms.TextBox IPPrimitiveTxt;
        private System.Windows.Forms.Label IPPacketInfoLbl;
        private System.Windows.Forms.Label IPIsCorruptedLbl;
        private System.Windows.Forms.CheckBox ISAutoStartChckbx;
        private Sulakore.Components.SKoreExtensionView EExtensionsLstvw;
        private Sulakore.Components.SKoreTabControl OOptionsTab;
        private System.Windows.Forms.TabPage OAboutTab;
        private System.Windows.Forms.ToolTip TanjiTip;
        private System.Windows.Forms.TabPage OSettingsTab;
        private System.Windows.Forms.CheckBox OSCloseOnDisconnectChckbx;
        private System.Windows.Forms.ToolStripStatusLabel VersionTxt;
        private System.Windows.Forms.CheckBox OSAlwaysOnTopChckbx;
        private Sulakore.Components.SKoreTabControl IFFilterModeTabs;
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
        private System.Windows.Forms.TextBox EDShortOutputTxt;
        private System.Windows.Forms.TextBox EDIntegerOutputTxt;
        private System.Windows.Forms.TextBox EDShortInputTxt;
        private Sulakore.Components.SKoreButton EDEncodeShortBtn;
        private Sulakore.Components.SKoreButton EDEncodeIntegerBtn;
        private Sulakore.Components.SKoreButton EDDecodeShortBtn;
        private Sulakore.Components.SKoreButton EDDecodeIntegerBtn;
        private System.Windows.Forms.TextBox EDIntegerInputTxt;
        private System.Windows.Forms.Panel EDMiddleGlowPnl;
        private System.Windows.Forms.Label EDEncodedBlocksLbl;
        private System.Windows.Forms.TextBox EDEncodedBlocksTxt;
        private Sulakore.Components.SKoreButton EDExtractValuesBtn;
        private Sulakore.Components.SKoreListView EDExtracterLstvw;
        private System.Windows.Forms.ColumnHeader ValueCol;
        private System.Windows.Forms.ColumnHeader EncodedCol;
        private System.Windows.Forms.ColumnHeader PositionCol;
        private System.Windows.Forms.LinkLabel TRequestLbl;
        private System.Windows.Forms.Label TSuggestLbl;
        private System.Windows.Forms.Label IFBDestinationLbl;
        private System.Windows.Forms.ComboBox IFBDestinationTxt;
        private System.Windows.Forms.TextBox IFBHeaderTxt;
        private System.Windows.Forms.Label IFBHeaderLbl;
        private Sulakore.Components.SKoreButton IFBUnblockBtn;
        private Sulakore.Components.SKoreButton IFBBlockBtn;
        private Sulakore.Components.SKoreListView IFBBlockLstvw;
        private System.Windows.Forms.ColumnHeader BDestinationCol;
        private System.Windows.Forms.ColumnHeader BHeaderCol;
        private System.Windows.Forms.ColumnHeader BPublisherCol;
        private Sulakore.Components.SKoreListView IFRReplaceLstvw;
        private System.Windows.Forms.ColumnHeader RDestinationCol;
        private System.Windows.Forms.ColumnHeader RHeaderCol;
        private System.Windows.Forms.ColumnHeader RReplacementCol;
        private System.Windows.Forms.TextBox IFRReplacementTxt;
        private System.Windows.Forms.Label IFReplacementLbl;
        private System.Windows.Forms.Label IFRDestinationLbl;
        private System.Windows.Forms.ComboBox IFRDestinationTxt;
        private System.Windows.Forms.TextBox IFRHeaderTxt;
        private System.Windows.Forms.Label IFRHeaderLbl;
        private Sulakore.Components.SKoreButton IFRUnreplaceBtn;
        private Sulakore.Components.SKoreButton IFRReplaceBtn;
        private System.Windows.Forms.ComboBox ITSavedTriggers;
        private Sulakore.Components.SKoreButton sKoreButton1;
        private Sulakore.Components.SKoreListView sKoreListView1;
        private System.Windows.Forms.ColumnHeader ITTypePropertyCol;
        private System.Windows.Forms.ColumnHeader ITPosition;
        private System.Windows.Forms.ColumnHeader ITPredicate;
        private System.Windows.Forms.ColumnHeader ITCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ITNotDoneLbl;

    }
}

