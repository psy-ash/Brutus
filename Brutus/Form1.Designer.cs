using System.Windows.Forms;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.WinForms;

namespace Brutus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties coreWebView2CreationProperties1 = new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Window = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TimeLineTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LoopChecked = new System.Windows.Forms.CheckBox();
            this.StopTL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.Timeline = new System.Windows.Forms.Panel();
            this.tlTicker = new System.Windows.Forms.Panel();
            this.timelineIMG = new System.Windows.Forms.PictureBox();
            this.timelineOptionsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.loopMinutesNB = new System.Windows.Forms.NumericUpDown();
            this.DebugLog = new System.Windows.Forms.TabPage();
            this.Debug_Screen = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_Tools = new System.Windows.Forms.Panel();
            this.testBox = new System.Windows.Forms.RichTextBox();
            this.ToggleWebPageUI = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.fwrdBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ZoomValue = new System.Windows.Forms.NumericUpDown();
            this.animTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLineCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTimelineEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TimeLineTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Timeline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timelineIMG)).BeginInit();
            this.timelineOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loopMinutesNB)).BeginInit();
            this.DebugLog.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Main_Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomValue)).BeginInit();
            this.TimeLineCM.SuspendLayout();
            this.WindowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Window);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 884);
            this.panel1.TabIndex = 0;
            // 
            // Window
            // 
            this.Window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Window.BackColor = System.Drawing.SystemColors.AppWorkspace;
            coreWebView2CreationProperties1.BrowserExecutableFolder = null;
            coreWebView2CreationProperties1.Language = null;
            coreWebView2CreationProperties1.UserDataFolder = null;
            this.Window.CreationProperties = coreWebView2CreationProperties1;
            this.Window.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Window.DefaultBackgroundColor = System.Drawing.Color.DimGray;
            this.Window.Location = new System.Drawing.Point(3, 27);
            this.Window.MinimumSize = new System.Drawing.Size(20, 20);
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(1278, 647);
            this.Window.Source = new System.Uri("https://wallet.mymonero.com/", System.UriKind.Absolute);
            this.Window.TabIndex = 4;
            this.Window.ZoomFactor = 1D;
            this.Window.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.WebView21_CoreWebView2InitializationCompleted);
            this.Window.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.Window_NavigationCompleted);
            this.Window.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.WebView21_WebMessageReceived);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menuStrip);
            this.panel4.Controls.Add(this.TabControl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1281, 884);
            this.panel4.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1281, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStripMenuItem,
            this.saveStripMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // openStripMenuItem
            // 
            this.openStripMenuItem.Name = "openStripMenuItem";
            this.openStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openStripMenuItem.Text = "Open Timeline";
            this.openStripMenuItem.Click += new System.EventHandler(this.openStripMenuItem_Click);
            // 
            // saveStripMenuItem
            // 
            this.saveStripMenuItem.Name = "saveStripMenuItem";
            this.saveStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveStripMenuItem.Text = "Save Timeline";
            this.saveStripMenuItem.Click += new System.EventHandler(this.saveStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsManagerToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // settingsManagerToolStripMenuItem
            // 
            this.settingsManagerToolStripMenuItem.Name = "settingsManagerToolStripMenuItem";
            this.settingsManagerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.settingsManagerToolStripMenuItem.Text = "Settings Manager";
            this.settingsManagerToolStripMenuItem.Click += new System.EventHandler(this.settingsManagerToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TimeLineTab);
            this.TabControl.Controls.Add(this.DebugLog);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl.Location = new System.Drawing.Point(0, 677);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1281, 207);
            this.TabControl.TabIndex = 6;
            // 
            // TimeLineTab
            // 
            this.TimeLineTab.BackColor = System.Drawing.Color.Gainsboro;
            this.TimeLineTab.Controls.Add(this.panel5);
            this.TimeLineTab.Controls.Add(this.Timeline);
            this.TimeLineTab.Controls.Add(this.timelineOptionsPanel);
            this.TimeLineTab.Location = new System.Drawing.Point(4, 22);
            this.TimeLineTab.Name = "TimeLineTab";
            this.TimeLineTab.Padding = new System.Windows.Forms.Padding(3);
            this.TimeLineTab.Size = new System.Drawing.Size(1273, 181);
            this.TimeLineTab.TabIndex = 1;
            this.TimeLineTab.Text = "TimeLine";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LoopChecked);
            this.panel5.Controls.Add(this.StopTL);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.playBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1196, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(74, 175);
            this.panel5.TabIndex = 5;
            // 
            // LoopChecked
            // 
            this.LoopChecked.AutoSize = true;
            this.LoopChecked.Location = new System.Drawing.Point(7, 143);
            this.LoopChecked.Name = "LoopChecked";
            this.LoopChecked.Size = new System.Drawing.Size(50, 17);
            this.LoopChecked.TabIndex = 6;
            this.LoopChecked.Text = "Loop";
            this.toolTip.SetToolTip(this.LoopChecked, "Toggles The Bot Playing");
            this.LoopChecked.UseVisualStyleBackColor = true;
            this.LoopChecked.CheckedChanged += new System.EventHandler(this.LoopingButton_Click);
            // 
            // StopTL
            // 
            this.StopTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopTL.Location = new System.Drawing.Point(6, 53);
            this.StopTL.Name = "StopTL";
            this.StopTL.Size = new System.Drawing.Size(63, 33);
            this.StopTL.TabIndex = 5;
            this.StopTL.Text = "Stop";
            this.toolTip.SetToolTip(this.StopTL, "Stop Running Bot");
            this.StopTL.UseVisualStyleBackColor = true;
            this.StopTL.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.toolTip.SetToolTip(this.button1, "Clear All Events From Timeline");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(6, 92);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(64, 45);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.toolTip.SetToolTip(this.playBtn, "Start/Pause The Bot ");
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // Timeline
            // 
            this.Timeline.AutoScroll = true;
            this.Timeline.BackColor = System.Drawing.Color.Bisque;
            this.Timeline.Controls.Add(this.tlTicker);
            this.Timeline.Controls.Add(this.timelineIMG);
            this.Timeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timeline.Location = new System.Drawing.Point(104, 3);
            this.Timeline.Name = "Timeline";
            this.Timeline.Size = new System.Drawing.Size(1166, 175);
            this.Timeline.TabIndex = 0;
            this.Timeline.Paint += new System.Windows.Forms.PaintEventHandler(this.Timeline_Paint);
            this.Timeline.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaceEvent);
            // 
            // tlTicker
            // 
            this.tlTicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlTicker.BackColor = System.Drawing.Color.DimGray;
            this.tlTicker.BackgroundImage = global::Brutus.Properties.Resources.Timeticker;
            this.tlTicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tlTicker.Location = new System.Drawing.Point(3, 3);
            this.tlTicker.Name = "tlTicker";
            this.tlTicker.Size = new System.Drawing.Size(16, 16);
            this.tlTicker.TabIndex = 3;
            // 
            // timelineIMG
            // 
            this.timelineIMG.Dock = System.Windows.Forms.DockStyle.Top;
            this.timelineIMG.Location = new System.Drawing.Point(0, 0);
            this.timelineIMG.Name = "timelineIMG";
            this.timelineIMG.Size = new System.Drawing.Size(1166, 21);
            this.timelineIMG.TabIndex = 2;
            this.timelineIMG.TabStop = false;
            this.timelineIMG.Visible = false;
            // 
            // timelineOptionsPanel
            // 
            this.timelineOptionsPanel.Controls.Add(this.label2);
            this.timelineOptionsPanel.Controls.Add(this.loopMinutesNB);
            this.timelineOptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.timelineOptionsPanel.Location = new System.Drawing.Point(3, 3);
            this.timelineOptionsPanel.Name = "timelineOptionsPanel";
            this.timelineOptionsPanel.Size = new System.Drawing.Size(101, 175);
            this.timelineOptionsPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length In Minutes";
            // 
            // loopMinutesNB
            // 
            this.loopMinutesNB.DecimalPlaces = 1;
            this.loopMinutesNB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.loopMinutesNB.Location = new System.Drawing.Point(34, 23);
            this.loopMinutesNB.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.loopMinutesNB.Name = "loopMinutesNB";
            this.loopMinutesNB.Size = new System.Drawing.Size(42, 20);
            this.loopMinutesNB.TabIndex = 0;
            this.toolTip.SetToolTip(this.loopMinutesNB, "Play Length Of Bot");
            this.loopMinutesNB.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.loopMinutesNB.ValueChanged += new System.EventHandler(this.loopMinutesNB_ValueChanged);
            // 
            // DebugLog
            // 
            this.DebugLog.BackColor = System.Drawing.Color.Linen;
            this.DebugLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DebugLog.Controls.Add(this.Debug_Screen);
            this.DebugLog.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DebugLog.Location = new System.Drawing.Point(4, 22);
            this.DebugLog.Name = "DebugLog";
            this.DebugLog.Padding = new System.Windows.Forms.Padding(3);
            this.DebugLog.Size = new System.Drawing.Size(1273, 181);
            this.DebugLog.TabIndex = 0;
            this.DebugLog.Text = "Debug Log";
            // 
            // Debug_Screen
            // 
            this.Debug_Screen.BackColor = System.Drawing.Color.Linen;
            this.Debug_Screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Debug_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Debug_Screen.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.Debug_Screen.FormattingEnabled = true;
            this.Debug_Screen.HorizontalScrollbar = true;
            this.Debug_Screen.ItemHeight = 14;
            this.Debug_Screen.Location = new System.Drawing.Point(3, 3);
            this.Debug_Screen.MultiColumn = true;
            this.Debug_Screen.Name = "Debug_Screen";
            this.Debug_Screen.Size = new System.Drawing.Size(1265, 173);
            this.Debug_Screen.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_Tools);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1281, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 884);
            this.panel3.TabIndex = 7;
            // 
            // Main_Tools
            // 
            this.Main_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Tools.AutoSize = true;
            this.Main_Tools.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Main_Tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_Tools.Controls.Add(this.testBox);
            this.Main_Tools.Controls.Add(this.ToggleWebPageUI);
            this.Main_Tools.Controls.Add(this.refreshBtn);
            this.Main_Tools.Controls.Add(this.fwrdBtn);
            this.Main_Tools.Controls.Add(this.backBtn);
            this.Main_Tools.Controls.Add(this.label1);
            this.Main_Tools.Controls.Add(this.SearchBar);
            this.Main_Tools.Controls.Add(this.label3);
            this.Main_Tools.Controls.Add(this.ZoomValue);
            this.Main_Tools.Location = new System.Drawing.Point(0, 3);
            this.Main_Tools.Name = "Main_Tools";
            this.Main_Tools.Size = new System.Drawing.Size(280, 881);
            this.Main_Tools.TabIndex = 5;
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(15, 189);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(127, 203);
            this.testBox.TabIndex = 8;
            this.testBox.Text = "";
            // 
            // ToggleWebPageUI
            // 
            this.ToggleWebPageUI.BackColor = System.Drawing.Color.IndianRed;
            this.ToggleWebPageUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleWebPageUI.Location = new System.Drawing.Point(15, 84);
            this.ToggleWebPageUI.Name = "ToggleWebPageUI";
            this.ToggleWebPageUI.Size = new System.Drawing.Size(124, 27);
            this.ToggleWebPageUI.TabIndex = 7;
            this.ToggleWebPageUI.Text = "Read Page";
            this.toolTip.SetToolTip(this.ToggleWebPageUI, "Scan For Unique Identifiers");
            this.ToggleWebPageUI.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(13, 149);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(66, 24);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Refresh";
            this.toolTip.SetToolTip(this.refreshBtn, "Refresh Browser Page");
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // fwrdBtn
            // 
            this.fwrdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwrdBtn.Location = new System.Drawing.Point(71, 54);
            this.fwrdBtn.Name = "fwrdBtn";
            this.fwrdBtn.Size = new System.Drawing.Size(68, 24);
            this.fwrdBtn.TabIndex = 5;
            this.fwrdBtn.Text = "Forward";
            this.toolTip.SetToolTip(this.fwrdBtn, "Go Forwards On Browser");
            this.fwrdBtn.UseVisualStyleBackColor = true;
            this.fwrdBtn.Click += new System.EventHandler(this.fwrdBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(13, 54);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(58, 24);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.toolTip.SetToolTip(this.backBtn, "Go Back On Browser");
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(13, 28);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(126, 20);
            this.SearchBar.TabIndex = 2;
            this.toolTip.SetToolTip(this.SearchBar, "Shows The Browsers Current URL");
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zoom: ";
            // 
            // ZoomValue
            // 
            this.ZoomValue.BackColor = System.Drawing.Color.Linen;
            this.ZoomValue.Location = new System.Drawing.Point(79, 117);
            this.ZoomValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZoomValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ZoomValue.Name = "ZoomValue";
            this.ZoomValue.Size = new System.Drawing.Size(60, 20);
            this.ZoomValue.TabIndex = 0;
            this.toolTip.SetToolTip(this.ZoomValue, "Controls Zoom Level");
            this.ZoomValue.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.ZoomValue.ValueChanged += new System.EventHandler(this.ZoomValue_ValueChanged);
            // 
            // animTimer
            // 
            this.animTimer.Tick += new System.EventHandler(this.animTimer_Tick);
            // 
            // TimeLineCM
            // 
            this.TimeLineCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem});
            this.TimeLineCM.Name = "TimeLineCM";
            this.TimeLineCM.Size = new System.Drawing.Size(129, 26);
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // WindowContextMenu
            // 
            this.WindowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.backToolStripMenuItem,
            this.makeTimelineEventToolStripMenuItem,
            this.inspectToolStripMenuItem});
            this.WindowContextMenu.Name = "contextMenuStrip1";
            this.WindowContextMenu.Size = new System.Drawing.Size(184, 114);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // makeTimelineEventToolStripMenuItem
            // 
            this.makeTimelineEventToolStripMenuItem.Name = "makeTimelineEventToolStripMenuItem";
            this.makeTimelineEventToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.makeTimelineEventToolStripMenuItem.Text = "Make Timeline Event";
            this.makeTimelineEventToolStripMenuItem.Click += new System.EventHandler(this.makeTimelineEventToolStripMenuItem_Click);
            // 
            // inspectToolStripMenuItem
            // 
            this.inspectToolStripMenuItem.Name = "inspectToolStripMenuItem";
            this.inspectToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.inspectToolStripMenuItem.Text = "Inspect";
            this.inspectToolStripMenuItem.Click += new System.EventHandler(this.inspectToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1446, 884);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Brutus";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Window)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TimeLineTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Timeline.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timelineIMG)).EndInit();
            this.timelineOptionsPanel.ResumeLayout(false);
            this.timelineOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loopMinutesNB)).EndInit();
            this.DebugLog.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Main_Tools.ResumeLayout(false);
            this.Main_Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomValue)).EndInit();
            this.TimeLineCM.ResumeLayout(false);
            this.WindowContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox Debug_Screen;
        private WebView2 Window;
        private TabControl TabControl;
        private TabPage DebugLog;
        private TabPage TimeLineTab;
        private Panel Main_Tools;
        private Label label3;
        private NumericUpDown ZoomValue;
        private Panel panel3;
        private Panel panel4;
        private TextBox SearchBar;
        private Label label1;
        private Button button1;
        private PictureBox timelineIMG;
        private Button playBtn;
        private Panel tlTicker;
        private Panel timelineOptionsPanel;
        private Timer animTimer;
        private Label label2;
        private NumericUpDown loopMinutesNB;
        private Button StopTL;
        private Panel panel5;
        private Button refreshBtn;
        private Button fwrdBtn;
        private Button backBtn;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem openStripMenuItem;
        private ToolStripMenuItem saveStripMenuItem;
        private Button ToggleWebPageUI;
        private ContextMenuStrip TimeLineCM;
        private ToolStripMenuItem addEventToolStripMenuItem;
        private ContextMenuStrip WindowContextMenu;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem makeTimelineEventToolStripMenuItem;
        private ToolStripMenuItem inspectToolStripMenuItem;
        private RichTextBox testBox;
        private CheckBox LoopChecked;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem settingsManagerToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        public Panel Timeline;
        private ToolTip toolTip;
    }
}
