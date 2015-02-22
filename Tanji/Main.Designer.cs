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
            this.SchedulesTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExtensionsActiveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.VersionTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ICConstructMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ICSendToClientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICSendToServerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.IConstructSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ICCopyPacketBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICTransferToBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICSchedulerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EExtensionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EUninstallBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EExtensionsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.EInstallExtensionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseExtensionDlg = new System.Windows.Forms.OpenFileDialog();
            this.TanjiTip = new System.Windows.Forms.ToolTip(this.components);
            this.ISTanjiScheduler = new Sulakore.Components.SKoreScheduler();
            this.ISBurstTxt = new System.Windows.Forms.NumericUpDown();
            this.ISIntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.ISDescriptionTxt = new System.Windows.Forms.TextBox();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.IPacketTxt = new System.Windows.Forms.TextBox();
            this.PSendToClientBtn = new Sulakore.Components.SKoreButton();
            this.PSendToServerBtn = new Sulakore.Components.SKoreButton();
            this.IInjectionTabs = new Sulakore.Components.SKoreTabControl();
            this.IConstructerTab = new System.Windows.Forms.TabPage();
            this.ICCountTxt = new System.Windows.Forms.NumericUpDown();
            this.ICCountLbl = new System.Windows.Forms.Label();
            this.ICEditBtn = new Sulakore.Components.SKoreButton();
            this.ICRemoveBtn = new Sulakore.Components.SKoreButton();
            this.ICTransferBtn = new Sulakore.Components.SKoreButton();
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
            this.ICTanjiConstructer = new Sulakore.Components.SKoreConstructer();
            this.ISchedulerTab = new System.Windows.Forms.TabPage();
            this.ISAutoStartChckbx = new System.Windows.Forms.CheckBox();
            this.ISBurstLbl = new System.Windows.Forms.Label();
            this.ISStopAllBtn = new Sulakore.Components.SKoreButton();
            this.ISIntervalLbl = new System.Windows.Forms.Label();
            this.ISDirectionLbl = new System.Windows.Forms.Label();
            this.ISDirectionTxt = new System.Windows.Forms.ComboBox();
            this.ISPacketLbl = new System.Windows.Forms.Label();
            this.ISPacketTxt = new System.Windows.Forms.TextBox();
            this.ISDescriptionLbl = new System.Windows.Forms.Label();
            this.ISStartAllBtn = new Sulakore.Components.SKoreButton();
            this.ISEditBtn = new Sulakore.Components.SKoreButton();
            this.ISRemoveBtn = new Sulakore.Components.SKoreButton();
            this.ISCreateBtn = new Sulakore.Components.SKoreButton();
            this.IPrimitiveTab = new System.Windows.Forms.TabPage();
            this.IPIsCorruptedLbl = new System.Windows.Forms.Label();
            this.IPPacketInfoLbl = new System.Windows.Forms.Label();
            this.IPPacketTxt = new System.Windows.Forms.TextBox();
            this.ITriggersTab = new System.Windows.Forms.TabPage();
            this.IFiltersTab = new System.Windows.Forms.TabPage();
            this.tanjiTabControl3 = new Sulakore.Components.SKoreTabControl();
            this.IFBlockTab = new System.Windows.Forms.TabPage();
            this.IFSwitchTab = new System.Windows.Forms.TabPage();
            this.IFModifyTab = new System.Windows.Forms.TabPage();
            this.IFRepeatTab = new System.Windows.Forms.TabPage();
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
            this.EPriorityLbl = new System.Windows.Forms.Label();
            this.EPriorityTxt = new System.Windows.Forms.ComboBox();
            this.EMiddleGlowPnl = new System.Windows.Forms.Panel();
            this.EExtensionLogoPctbx = new System.Windows.Forms.PictureBox();
            this.ETopGlowPnl = new System.Windows.Forms.Panel();
            this.ETanjiExtensionViewer = new Sulakore.Components.SKoreExtensionView();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.OOptionsTab = new Sulakore.Components.SKoreTabControl();
            this.OSettingsTab = new System.Windows.Forms.TabPage();
            this.OSAlwaysOnTopChckbx = new System.Windows.Forms.CheckBox();
            this.OSTOLFGrpbx = new System.Windows.Forms.GroupBox();
            this.OSTransparencyChckbx = new System.Windows.Forms.CheckBox();
            this.OSDeactivatedChckbx = new System.Windows.Forms.CheckBox();
            this.OSTransparencyTbar = new System.Windows.Forms.TrackBar();
            this.OSScreenEdgeSnappingChckbx = new System.Windows.Forms.CheckBox();
            this.OSCloseOnDisconnectChckbx = new System.Windows.Forms.CheckBox();
            this.OAboutTab = new System.Windows.Forms.TabPage();
            this.TanjiStrip.SuspendLayout();
            this.ICConstructMenu.SuspendLayout();
            this.EExtensionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).BeginInit();
            this.TanjiTabs.SuspendLayout();
            this.InjectionTab.SuspendLayout();
            this.IInjectionTabs.SuspendLayout();
            this.IConstructerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICCountTxt)).BeginInit();
            this.ISchedulerTab.SuspendLayout();
            this.IPrimitiveTab.SuspendLayout();
            this.IFiltersTab.SuspendLayout();
            this.tanjiTabControl3.SuspendLayout();
            this.EncoderDecoderTab.SuspendLayout();
            this.ModernEncodingGrpbx.SuspendLayout();
            this.ExtensionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EExtensionLogoPctbx)).BeginInit();
            this.OptionsTab.SuspendLayout();
            this.OOptionsTab.SuspendLayout();
            this.OSettingsTab.SuspendLayout();
            this.OSTOLFGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OSTransparencyTbar)).BeginInit();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionTxt,
            this.SchedulesTxt,
            this.ExtensionsActiveTxt});
            this.TanjiStrip.Location = new System.Drawing.Point(0, 345);
            this.TanjiStrip.Name = "TanjiStrip";
            this.TanjiStrip.Size = new System.Drawing.Size(479, 24);
            this.TanjiStrip.SizingGrip = false;
            this.TanjiStrip.TabIndex = 4;
            this.TanjiStrip.Text = "statusStrip1";
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
            // ICConstructMenu
            // 
            this.ICConstructMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ICSendToClientBtn,
            this.ICSendToServerBtn,
            this.IConstructSeperator,
            this.ICCopyPacketBtn,
            this.ICTransferToBtn});
            this.ICConstructMenu.Name = "ConstructMenu";
            this.ICConstructMenu.Size = new System.Drawing.Size(153, 98);
            // 
            // ICSendToClientBtn
            // 
            this.ICSendToClientBtn.Name = "ICSendToClientBtn";
            this.ICSendToClientBtn.Size = new System.Drawing.Size(152, 22);
            this.ICSendToClientBtn.Text = "Send To Client";
            this.ICSendToClientBtn.Click += new System.EventHandler(this.ICSendToClientBtn_Click);
            // 
            // ICSendToServerBtn
            // 
            this.ICSendToServerBtn.Name = "ICSendToServerBtn";
            this.ICSendToServerBtn.Size = new System.Drawing.Size(152, 22);
            this.ICSendToServerBtn.Text = "Send To Server";
            this.ICSendToServerBtn.Click += new System.EventHandler(this.ICSendToServerBtn_Click);
            // 
            // IConstructSeperator
            // 
            this.IConstructSeperator.Name = "IConstructSeperator";
            this.IConstructSeperator.Size = new System.Drawing.Size(149, 6);
            // 
            // ICCopyPacketBtn
            // 
            this.ICCopyPacketBtn.Name = "ICCopyPacketBtn";
            this.ICCopyPacketBtn.Size = new System.Drawing.Size(152, 22);
            this.ICCopyPacketBtn.Text = "Copy Packet";
            this.ICCopyPacketBtn.Click += new System.EventHandler(this.ICCopyPacketBtn_Click);
            // 
            // ICTransferToBtn
            // 
            this.ICTransferToBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ICSchedulerBtn});
            this.ICTransferToBtn.Name = "ICTransferToBtn";
            this.ICTransferToBtn.Size = new System.Drawing.Size(152, 22);
            this.ICTransferToBtn.Text = "Transfer To";
            // 
            // ICSchedulerBtn
            // 
            this.ICSchedulerBtn.Name = "ICSchedulerBtn";
            this.ICSchedulerBtn.Size = new System.Drawing.Size(126, 22);
            this.ICSchedulerBtn.Text = "Scheduler";
            this.ICSchedulerBtn.Click += new System.EventHandler(this.ICSchedulerBtn_Click);
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
            this.EOpenBtn.Click += new System.EventHandler(this.EOpenBtn_Click);
            // 
            // EUninstallBtn
            // 
            this.EUninstallBtn.Enabled = false;
            this.EUninstallBtn.Name = "EUninstallBtn";
            this.EUninstallBtn.Size = new System.Drawing.Size(158, 22);
            this.EUninstallBtn.Text = "Uninstall";
            this.EUninstallBtn.Click += new System.EventHandler(this.EUninstallBtn_Click);
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
            // ISTanjiScheduler
            // 
            this.ISTanjiScheduler.FullRowSelect = true;
            this.ISTanjiScheduler.GridLines = true;
            this.ISTanjiScheduler.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ISTanjiScheduler.Location = new System.Drawing.Point(6, 6);
            this.ISTanjiScheduler.LockColumns = true;
            this.ISTanjiScheduler.MultiSelect = false;
            this.ISTanjiScheduler.Name = "ISTanjiScheduler";
            this.ISTanjiScheduler.ShowItemToolTips = true;
            this.ISTanjiScheduler.Size = new System.Drawing.Size(379, 141);
            this.ISTanjiScheduler.TabIndex = 41;
            this.TanjiTip.SetToolTip(this.ISTanjiScheduler, "To toggle, double click the selected schedule.");
            this.ISTanjiScheduler.UseCompatibleStateImageBehavior = false;
            this.ISTanjiScheduler.View = System.Windows.Forms.View.Details;
            this.ISTanjiScheduler.ScheduleTriggered += new System.EventHandler<Sulakore.Protocol.HScheduleTriggeredEventArgs>(this.ISTanjiScheduler_ScheduleTriggered);
            this.ISTanjiScheduler.ItemActivate += new System.EventHandler(this.ISTanjiScheduler_ItemActivate);
            this.ISTanjiScheduler.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ISTanjiScheduler_ItemSelectionChanged);
            // 
            // ISBurstTxt
            // 
            this.ISBurstTxt.Location = new System.Drawing.Point(315, 214);
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
            this.ISIntervalTxt.Location = new System.Drawing.Point(315, 175);
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
            this.ISDescriptionTxt.Size = new System.Drawing.Size(303, 20);
            this.ISDescriptionTxt.TabIndex = 31;
            this.TanjiTip.SetToolTip(this.ISDescriptionTxt, "The desciption of the schedule, this will be shown when hovering over the item in" +
        " the list.");
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
            this.InjectionTab.Controls.Add(this.PSendToClientBtn);
            this.InjectionTab.Controls.Add(this.PSendToServerBtn);
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
            // PSendToClientBtn
            // 
            this.PSendToClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PSendToClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.PSendToClientBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PSendToClientBtn.Location = new System.Drawing.Point(259, 285);
            this.PSendToClientBtn.Name = "PSendToClientBtn";
            this.PSendToClientBtn.Size = new System.Drawing.Size(100, 22);
            this.PSendToClientBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.PSendToClientBtn.TabIndex = 4;
            this.PSendToClientBtn.Text = "Send To Client";
            this.PSendToClientBtn.Click += new System.EventHandler(this.SendToClientBtn_Click);
            // 
            // PSendToServerBtn
            // 
            this.PSendToServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PSendToServerBtn.BackColor = System.Drawing.Color.Transparent;
            this.PSendToServerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PSendToServerBtn.Location = new System.Drawing.Point(365, 285);
            this.PSendToServerBtn.Name = "PSendToServerBtn";
            this.PSendToServerBtn.Size = new System.Drawing.Size(100, 22);
            this.PSendToServerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.PSendToServerBtn.TabIndex = 3;
            this.PSendToServerBtn.Text = "Send To Server";
            this.PSendToServerBtn.Click += new System.EventHandler(this.SendToServerBtn_Click);
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
            this.IConstructerTab.Controls.Add(this.ICCountTxt);
            this.IConstructerTab.Controls.Add(this.ICCountLbl);
            this.IConstructerTab.Controls.Add(this.ICEditBtn);
            this.IConstructerTab.Controls.Add(this.ICRemoveBtn);
            this.IConstructerTab.Controls.Add(this.ICTransferBtn);
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
            this.IConstructerTab.Controls.Add(this.ICTanjiConstructer);
            this.IConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.IConstructerTab.Name = "IConstructerTab";
            this.IConstructerTab.Padding = new System.Windows.Forms.Padding(3);
            this.IConstructerTab.Size = new System.Drawing.Size(392, 268);
            this.IConstructerTab.TabIndex = 1;
            this.IConstructerTab.Text = "Constructer";
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
            this.ICCountTxt.Size = new System.Drawing.Size(59, 20);
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
            // ICEditBtn
            // 
            this.ICEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICEditBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICEditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICEditBtn.Enabled = false;
            this.ICEditBtn.Location = new System.Drawing.Point(114, 240);
            this.ICEditBtn.Name = "ICEditBtn";
            this.ICEditBtn.Size = new System.Drawing.Size(57, 22);
            this.ICEditBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICEditBtn.TabIndex = 22;
            this.ICEditBtn.Text = "Edit";
            this.ICEditBtn.Click += new System.EventHandler(this.ICEditBtn_Click);
            // 
            // ICRemoveBtn
            // 
            this.ICRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICRemoveBtn.Enabled = false;
            this.ICRemoveBtn.Location = new System.Drawing.Point(177, 240);
            this.ICRemoveBtn.Name = "ICRemoveBtn";
            this.ICRemoveBtn.Size = new System.Drawing.Size(57, 22);
            this.ICRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICRemoveBtn.TabIndex = 21;
            this.ICRemoveBtn.Text = "Remove";
            this.ICRemoveBtn.Click += new System.EventHandler(this.ICRemoveBtn_Click);
            // 
            // ICTransferBtn
            // 
            this.ICTransferBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICTransferBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICTransferBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICTransferBtn.Location = new System.Drawing.Point(7, 240);
            this.ICTransferBtn.Name = "ICTransferBtn";
            this.ICTransferBtn.Size = new System.Drawing.Size(101, 22);
            this.ICTransferBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICTransferBtn.TabIndex = 20;
            this.ICTransferBtn.Text = "Transfer (Below)";
            this.ICTransferBtn.Click += new System.EventHandler(this.ICTransferBtn_Click);
            // 
            // ICMoveDownBtn
            // 
            this.ICMoveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICMoveDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICMoveDownBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICMoveDownBtn.Enabled = false;
            this.ICMoveDownBtn.Location = new System.Drawing.Point(240, 240);
            this.ICMoveDownBtn.Name = "ICMoveDownBtn";
            this.ICMoveDownBtn.Size = new System.Drawing.Size(70, 22);
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
            this.ICMoveUpBtn.Location = new System.Drawing.Point(316, 240);
            this.ICMoveUpBtn.Name = "ICMoveUpBtn";
            this.ICMoveUpBtn.Size = new System.Drawing.Size(70, 22);
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
            // 
            // ICTanjiConstructer
            // 
            this.ICTanjiConstructer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ICTanjiConstructer.ContextMenuStrip = this.ICConstructMenu;
            this.ICTanjiConstructer.FullRowSelect = true;
            this.ICTanjiConstructer.GridLines = true;
            this.ICTanjiConstructer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ICTanjiConstructer.Location = new System.Drawing.Point(6, 73);
            this.ICTanjiConstructer.LockColumns = false;
            this.ICTanjiConstructer.MultiSelect = false;
            this.ICTanjiConstructer.Name = "ICTanjiConstructer";
            this.ICTanjiConstructer.ShowItemToolTips = true;
            this.ICTanjiConstructer.Size = new System.Drawing.Size(380, 161);
            this.ICTanjiConstructer.TabIndex = 0;
            this.ICTanjiConstructer.UseCompatibleStateImageBehavior = false;
            this.ICTanjiConstructer.View = System.Windows.Forms.View.Details;
            this.ICTanjiConstructer.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ICTanjiConstructer_ItemSelectionChanged);
            this.ICTanjiConstructer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ICTanjiConstructer_MouseDoubleClick);
            // 
            // ISchedulerTab
            // 
            this.ISchedulerTab.BackColor = System.Drawing.Color.White;
            this.ISchedulerTab.Controls.Add(this.ISAutoStartChckbx);
            this.ISchedulerTab.Controls.Add(this.ISTanjiScheduler);
            this.ISchedulerTab.Controls.Add(this.ISBurstLbl);
            this.ISchedulerTab.Controls.Add(this.ISBurstTxt);
            this.ISchedulerTab.Controls.Add(this.ISStopAllBtn);
            this.ISchedulerTab.Controls.Add(this.ISIntervalLbl);
            this.ISchedulerTab.Controls.Add(this.ISIntervalTxt);
            this.ISchedulerTab.Controls.Add(this.ISDirectionLbl);
            this.ISchedulerTab.Controls.Add(this.ISDirectionTxt);
            this.ISchedulerTab.Controls.Add(this.ISPacketLbl);
            this.ISchedulerTab.Controls.Add(this.ISPacketTxt);
            this.ISchedulerTab.Controls.Add(this.ISDescriptionLbl);
            this.ISchedulerTab.Controls.Add(this.ISDescriptionTxt);
            this.ISchedulerTab.Controls.Add(this.ISStartAllBtn);
            this.ISchedulerTab.Controls.Add(this.ISEditBtn);
            this.ISchedulerTab.Controls.Add(this.ISRemoveBtn);
            this.ISchedulerTab.Controls.Add(this.ISCreateBtn);
            this.ISchedulerTab.Location = new System.Drawing.Point(4, 4);
            this.ISchedulerTab.Name = "ISchedulerTab";
            this.ISchedulerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ISchedulerTab.Size = new System.Drawing.Size(392, 268);
            this.ISchedulerTab.TabIndex = 2;
            this.ISchedulerTab.Text = "Scheduler";
            // 
            // ISAutoStartChckbx
            // 
            this.ISAutoStartChckbx.AutoSize = true;
            this.ISAutoStartChckbx.Checked = true;
            this.ISAutoStartChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ISAutoStartChckbx.Location = new System.Drawing.Point(160, 158);
            this.ISAutoStartChckbx.Name = "ISAutoStartChckbx";
            this.ISAutoStartChckbx.Size = new System.Drawing.Size(73, 17);
            this.ISAutoStartChckbx.TabIndex = 42;
            this.ISAutoStartChckbx.Text = "Auto Start";
            this.ISAutoStartChckbx.UseVisualStyleBackColor = true;
            // 
            // ISBurstLbl
            // 
            this.ISBurstLbl.AutoSize = true;
            this.ISBurstLbl.Location = new System.Drawing.Point(312, 198);
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
            this.ISStopAllBtn.Location = new System.Drawing.Point(6, 240);
            this.ISStopAllBtn.Name = "ISStopAllBtn";
            this.ISStopAllBtn.Size = new System.Drawing.Size(75, 22);
            this.ISStopAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISStopAllBtn.TabIndex = 28;
            this.ISStopAllBtn.Text = "Stop All";
            this.ISStopAllBtn.Click += new System.EventHandler(this.ISStopAllBtn_Click);
            // 
            // ISIntervalLbl
            // 
            this.ISIntervalLbl.AutoSize = true;
            this.ISIntervalLbl.Location = new System.Drawing.Point(312, 159);
            this.ISIntervalLbl.Name = "ISIntervalLbl";
            this.ISIntervalLbl.Size = new System.Drawing.Size(64, 13);
            this.ISIntervalLbl.TabIndex = 38;
            this.ISIntervalLbl.Text = "Interval (ms)";
            // 
            // ISDirectionLbl
            // 
            this.ISDirectionLbl.AutoSize = true;
            this.ISDirectionLbl.Location = new System.Drawing.Point(230, 159);
            this.ISDirectionLbl.Name = "ISDirectionLbl";
            this.ISDirectionLbl.Size = new System.Drawing.Size(49, 13);
            this.ISDirectionLbl.TabIndex = 36;
            this.ISDirectionLbl.Text = "Direction";
            // 
            // ISDirectionTxt
            // 
            this.ISDirectionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISDirectionTxt.FormattingEnabled = true;
            this.ISDirectionTxt.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.ISDirectionTxt.Location = new System.Drawing.Point(233, 174);
            this.ISDirectionTxt.Name = "ISDirectionTxt";
            this.ISDirectionTxt.Size = new System.Drawing.Size(76, 21);
            this.ISDirectionTxt.TabIndex = 35;
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
            this.ISPacketTxt.Size = new System.Drawing.Size(221, 20);
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
            this.ISStartAllBtn.Location = new System.Drawing.Point(87, 240);
            this.ISStartAllBtn.Name = "ISStartAllBtn";
            this.ISStartAllBtn.Size = new System.Drawing.Size(70, 22);
            this.ISStartAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISStartAllBtn.TabIndex = 29;
            this.ISStartAllBtn.Text = "Start All";
            this.ISStartAllBtn.Click += new System.EventHandler(this.ISStartAllBtn_Click);
            // 
            // ISEditBtn
            // 
            this.ISEditBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISEditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISEditBtn.Enabled = false;
            this.ISEditBtn.Location = new System.Drawing.Point(239, 240);
            this.ISEditBtn.Name = "ISEditBtn";
            this.ISEditBtn.Size = new System.Drawing.Size(70, 22);
            this.ISEditBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISEditBtn.TabIndex = 27;
            this.ISEditBtn.Text = "Edit";
            this.ISEditBtn.Click += new System.EventHandler(this.ISEditBtn_Click);
            // 
            // ISRemoveBtn
            // 
            this.ISRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISRemoveBtn.Enabled = false;
            this.ISRemoveBtn.Location = new System.Drawing.Point(163, 240);
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
            this.ISCreateBtn.Location = new System.Drawing.Point(315, 240);
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
            this.IFiltersTab.Controls.Add(this.tanjiTabControl3);
            this.IFiltersTab.Location = new System.Drawing.Point(4, 4);
            this.IFiltersTab.Name = "IFiltersTab";
            this.IFiltersTab.Padding = new System.Windows.Forms.Padding(3);
            this.IFiltersTab.Size = new System.Drawing.Size(392, 268);
            this.IFiltersTab.TabIndex = 4;
            this.IFiltersTab.Text = "Filters";
            // 
            // tanjiTabControl3
            // 
            this.tanjiTabControl3.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tanjiTabControl3.Controls.Add(this.IFBlockTab);
            this.tanjiTabControl3.Controls.Add(this.IFSwitchTab);
            this.tanjiTabControl3.Controls.Add(this.IFModifyTab);
            this.tanjiTabControl3.Controls.Add(this.IFRepeatTab);
            this.tanjiTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanjiTabControl3.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tanjiTabControl3.Location = new System.Drawing.Point(3, 3);
            this.tanjiTabControl3.Multiline = true;
            this.tanjiTabControl3.Name = "tanjiTabControl3";
            this.tanjiTabControl3.SelectedIndex = 0;
            this.tanjiTabControl3.Size = new System.Drawing.Size(386, 262);
            this.tanjiTabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tanjiTabControl3.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tanjiTabControl3.TabIndex = 0;
            // 
            // IFBlockTab
            // 
            this.IFBlockTab.BackColor = System.Drawing.Color.White;
            this.IFBlockTab.Location = new System.Drawing.Point(4, 4);
            this.IFBlockTab.Name = "IFBlockTab";
            this.IFBlockTab.Size = new System.Drawing.Size(378, 230);
            this.IFBlockTab.TabIndex = 0;
            this.IFBlockTab.Text = "Block";
            // 
            // IFSwitchTab
            // 
            this.IFSwitchTab.BackColor = System.Drawing.Color.White;
            this.IFSwitchTab.Location = new System.Drawing.Point(4, 4);
            this.IFSwitchTab.Name = "IFSwitchTab";
            this.IFSwitchTab.Size = new System.Drawing.Size(378, 230);
            this.IFSwitchTab.TabIndex = 1;
            this.IFSwitchTab.Text = "Switch";
            // 
            // IFModifyTab
            // 
            this.IFModifyTab.BackColor = System.Drawing.Color.White;
            this.IFModifyTab.Location = new System.Drawing.Point(4, 4);
            this.IFModifyTab.Name = "IFModifyTab";
            this.IFModifyTab.Size = new System.Drawing.Size(378, 230);
            this.IFModifyTab.TabIndex = 2;
            this.IFModifyTab.Text = "Modify";
            // 
            // IFRepeatTab
            // 
            this.IFRepeatTab.BackColor = System.Drawing.Color.White;
            this.IFRepeatTab.Location = new System.Drawing.Point(4, 4);
            this.IFRepeatTab.Name = "IFRepeatTab";
            this.IFRepeatTab.Size = new System.Drawing.Size(378, 230);
            this.IFRepeatTab.TabIndex = 3;
            this.IFRepeatTab.Text = "Repeat";
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
            this.ExtensionsTab.Controls.Add(this.EPriorityLbl);
            this.ExtensionsTab.Controls.Add(this.EPriorityTxt);
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
            // EPriorityLbl
            // 
            this.EPriorityLbl.AutoSize = true;
            this.EPriorityLbl.Location = new System.Drawing.Point(303, 289);
            this.EPriorityLbl.Name = "EPriorityLbl";
            this.EPriorityLbl.Size = new System.Drawing.Size(41, 13);
            this.EPriorityLbl.TabIndex = 4;
            this.EPriorityLbl.Text = "Priority:";
            // 
            // EPriorityTxt
            // 
            this.EPriorityTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EPriorityTxt.Enabled = false;
            this.EPriorityTxt.FormattingEnabled = true;
            this.EPriorityTxt.Items.AddRange(new object[] {
            "Normal",
            "High"});
            this.EPriorityTxt.Location = new System.Drawing.Point(344, 286);
            this.EPriorityTxt.Name = "EPriorityTxt";
            this.EPriorityTxt.Size = new System.Drawing.Size(121, 21);
            this.EPriorityTxt.TabIndex = 3;
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
            this.ETanjiExtensionViewer.ContextMenuStrip = this.EExtensionMenu;
            this.ETanjiExtensionViewer.Contractor = null;
            this.ETanjiExtensionViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ETanjiExtensionViewer.FullRowSelect = true;
            this.ETanjiExtensionViewer.GridLines = true;
            this.ETanjiExtensionViewer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ETanjiExtensionViewer.Location = new System.Drawing.Point(3, 3);
            this.ETanjiExtensionViewer.LockColumns = false;
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
            this.OSettingsTab.Controls.Add(this.OSTOLFGrpbx);
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
            // OSTOLFGrpbx
            // 
            this.OSTOLFGrpbx.Controls.Add(this.OSTransparencyChckbx);
            this.OSTOLFGrpbx.Controls.Add(this.OSDeactivatedChckbx);
            this.OSTOLFGrpbx.Controls.Add(this.OSTransparencyTbar);
            this.OSTOLFGrpbx.Location = new System.Drawing.Point(6, 223);
            this.OSTOLFGrpbx.Name = "OSTOLFGrpbx";
            this.OSTOLFGrpbx.Size = new System.Drawing.Size(387, 70);
            this.OSTOLFGrpbx.TabIndex = 3;
            this.OSTOLFGrpbx.TabStop = false;
            this.OSTOLFGrpbx.Text = "Transparency";
            // 
            // OSTransparencyChckbx
            // 
            this.OSTransparencyChckbx.AutoSize = true;
            this.OSTransparencyChckbx.Location = new System.Drawing.Point(316, 0);
            this.OSTransparencyChckbx.Name = "OSTransparencyChckbx";
            this.OSTransparencyChckbx.Size = new System.Drawing.Size(65, 17);
            this.OSTransparencyChckbx.TabIndex = 4;
            this.OSTransparencyChckbx.Text = "Enabled";
            this.OSTransparencyChckbx.UseVisualStyleBackColor = true;
            this.OSTransparencyChckbx.CheckedChanged += new System.EventHandler(this.OSTransparencyChckbx_CheckedChanged);
            // 
            // OSDeactivatedChckbx
            // 
            this.OSDeactivatedChckbx.AutoSize = true;
            this.OSDeactivatedChckbx.Enabled = false;
            this.OSDeactivatedChckbx.Location = new System.Drawing.Point(191, 0);
            this.OSDeactivatedChckbx.Name = "OSDeactivatedChckbx";
            this.OSDeactivatedChckbx.Size = new System.Drawing.Size(125, 17);
            this.OSDeactivatedChckbx.TabIndex = 5;
            this.OSDeactivatedChckbx.Text = "Only On Deactivated";
            this.OSDeactivatedChckbx.UseVisualStyleBackColor = true;
            this.OSDeactivatedChckbx.CheckedChanged += new System.EventHandler(this.OSDeactivatedChckbx_CheckedChanged);
            // 
            // OSTransparencyTbar
            // 
            this.OSTransparencyTbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OSTransparencyTbar.Enabled = false;
            this.OSTransparencyTbar.Location = new System.Drawing.Point(3, 16);
            this.OSTransparencyTbar.Maximum = 100;
            this.OSTransparencyTbar.Minimum = 10;
            this.OSTransparencyTbar.Name = "OSTransparencyTbar";
            this.OSTransparencyTbar.Size = new System.Drawing.Size(381, 51);
            this.OSTransparencyTbar.TabIndex = 4;
            this.OSTransparencyTbar.Value = 100;
            this.OSTransparencyTbar.ValueChanged += new System.EventHandler(this.OSTransparencyTbar_ValueChanged);
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
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.ICConstructMenu.ResumeLayout(false);
            this.EExtensionMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).EndInit();
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
            this.tanjiTabControl3.ResumeLayout(false);
            this.EncoderDecoderTab.ResumeLayout(false);
            this.ModernEncodingGrpbx.ResumeLayout(false);
            this.ModernEncodingGrpbx.PerformLayout();
            this.ExtensionsTab.ResumeLayout(false);
            this.ExtensionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EExtensionLogoPctbx)).EndInit();
            this.OptionsTab.ResumeLayout(false);
            this.OOptionsTab.ResumeLayout(false);
            this.OSettingsTab.ResumeLayout(false);
            this.OSettingsTab.PerformLayout();
            this.OSTOLFGrpbx.ResumeLayout(false);
            this.OSTOLFGrpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OSTransparencyTbar)).EndInit();
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
        private Sulakore.Components.SKoreButton PSendToClientBtn;
        private Sulakore.Components.SKoreButton PSendToServerBtn;
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
        private Sulakore.Components.SKoreConstructer ICTanjiConstructer;
        private System.Windows.Forms.Label ICHeaderLbl;
        private System.Windows.Forms.TextBox ICHeaderTxt;
        private System.Windows.Forms.Label ICValueLbl;
        private System.Windows.Forms.TextBox ICValueTxt;
        private Sulakore.Components.SKoreButton ICAppendBooleanBtn;
        private Sulakore.Components.SKoreButton ICAppendStringBtn;
        private Sulakore.Components.SKoreButton ICAppendIntegerBtn;
        private Sulakore.Components.SKoreButton ICClearBtn;
        private Sulakore.Components.SKoreButton ICEditBtn;
        private Sulakore.Components.SKoreButton ICRemoveBtn;
        private Sulakore.Components.SKoreButton ICTransferBtn;
        private Sulakore.Components.SKoreButton ICMoveDownBtn;
        private Sulakore.Components.SKoreButton ICMoveUpBtn;
        private System.Windows.Forms.ContextMenuStrip ICConstructMenu;
        private System.Windows.Forms.ToolStripMenuItem ICSendToClientBtn;
        private System.Windows.Forms.ToolStripMenuItem ICSendToServerBtn;
        private System.Windows.Forms.ToolStripSeparator IConstructSeperator;
        private System.Windows.Forms.ToolStripMenuItem ICCopyPacketBtn;
        private System.Windows.Forms.ContextMenuStrip EExtensionMenu;
        private System.Windows.Forms.ToolStripMenuItem EOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem EUninstallBtn;
        private System.Windows.Forms.ToolStripSeparator EExtensionsSeperator;
        private System.Windows.Forms.ToolStripMenuItem EInstallExtensionBtn;
        private System.Windows.Forms.Label ISBurstLbl;
        private System.Windows.Forms.NumericUpDown ISBurstTxt;
        private System.Windows.Forms.Label ISIntervalLbl;
        private System.Windows.Forms.NumericUpDown ISIntervalTxt;
        private System.Windows.Forms.Label ISDirectionLbl;
        private System.Windows.Forms.ComboBox ISDirectionTxt;
        private System.Windows.Forms.Label ISPacketLbl;
        private System.Windows.Forms.TextBox ISPacketTxt;
        private System.Windows.Forms.Label ISDescriptionLbl;
        private System.Windows.Forms.TextBox ISDescriptionTxt;
        private Sulakore.Components.SKoreButton ISStartAllBtn;
        private Sulakore.Components.SKoreButton ISStopAllBtn;
        private Sulakore.Components.SKoreButton ISEditBtn;
        private Sulakore.Components.SKoreButton ISRemoveBtn;
        private Sulakore.Components.SKoreButton ISCreateBtn;
        private Sulakore.Components.SKoreScheduler ISTanjiScheduler;
        private System.Windows.Forms.OpenFileDialog ChooseExtensionDlg;
        private System.Windows.Forms.Label ICCountLbl;
        private System.Windows.Forms.NumericUpDown ICCountTxt;
        private System.Windows.Forms.TextBox IPPacketTxt;
        private System.Windows.Forms.Label IPPacketInfoLbl;
        private System.Windows.Forms.Label IPIsCorruptedLbl;
        private System.Windows.Forms.ToolStripMenuItem ICTransferToBtn;
        private System.Windows.Forms.ToolStripMenuItem ICSchedulerBtn;
        private System.Windows.Forms.CheckBox ISAutoStartChckbx;
        private Sulakore.Components.SKoreExtensionView ETanjiExtensionViewer;
        private Sulakore.Components.SKoreTabControl OOptionsTab;
        private System.Windows.Forms.TabPage OAboutTab;
        private System.Windows.Forms.ToolTip TanjiTip;
        private System.Windows.Forms.TabPage OSettingsTab;
        private System.Windows.Forms.CheckBox OSScreenEdgeSnappingChckbx;
        private System.Windows.Forms.CheckBox OSCloseOnDisconnectChckbx;
        private System.Windows.Forms.GroupBox OSTOLFGrpbx;
        private System.Windows.Forms.CheckBox OSTransparencyChckbx;
        private System.Windows.Forms.TrackBar OSTransparencyTbar;
        private System.Windows.Forms.ToolStripStatusLabel VersionTxt;
        private System.Windows.Forms.CheckBox OSAlwaysOnTopChckbx;
        private System.Windows.Forms.CheckBox OSDeactivatedChckbx;
        private Sulakore.Components.SKoreTabControl tanjiTabControl3;
        private System.Windows.Forms.TabPage IFBlockTab;
        private System.Windows.Forms.TabPage IFSwitchTab;
        private System.Windows.Forms.TabPage IFModifyTab;
        private System.Windows.Forms.TabPage IFRepeatTab;
        private System.Windows.Forms.Panel ETopGlowPnl;
        private System.Windows.Forms.PictureBox EExtensionLogoPctbx;
        private System.Windows.Forms.Panel EMiddleGlowPnl;
        private System.Windows.Forms.Label EPriorityLbl;
        private System.Windows.Forms.ComboBox EPriorityTxt;

    }
}

