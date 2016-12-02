namespace Tracking_Objects
{
    partial class Form_Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Map));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.dgvObjectList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTrack = new System.Windows.Forms.Panel();
            this.dgvLatLongList = new System.Windows.Forms.DataGridView();
            this.mCalTripRange = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowserTrack = new Awesomium.Windows.Forms.WebControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.slide = new System.Windows.Forms.Button();
            this.panelPlayButtons = new System.Windows.Forms.Panel();
            this.listViewObjectDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAppClose = new System.Windows.Forms.Button();
            this.btnObjectDetails = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFastPlay = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnTrackSlide = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnDrawTrack = new System.Windows.Forms.Button();
            this.btnSlide = new System.Windows.Forms.Button();
            this.btnSlide1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLatLongList)).BeginInit();
            this.panelPlayButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbSearch.Location = new System.Drawing.Point(41, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(224, 29);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btnSlide);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 42);
            this.panel1.TabIndex = 11;
            // 
            // cmbClients
            // 
            this.cmbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(6, 80);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(259, 21);
            this.cmbClients.TabIndex = 1;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(6, 107);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(259, 21);
            this.cmbGroups.TabIndex = 2;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            this.cmbGroups.Click += new System.EventHandler(this.cmbGroups_Click);
            // 
            // dgvObjectList
            // 
            this.dgvObjectList.AllowUserToAddRows = false;
            this.dgvObjectList.AllowUserToDeleteRows = false;
            this.dgvObjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectList.Location = new System.Drawing.Point(6, 134);
            this.dgvObjectList.Name = "dgvObjectList";
            this.dgvObjectList.RowHeadersVisible = false;
            this.dgvObjectList.Size = new System.Drawing.Size(259, 506);
            this.dgvObjectList.TabIndex = 3;
            this.dgvObjectList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvObjectList_CellFormatting);
            this.dgvObjectList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvObjectList_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnSlide1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dgvObjectList);
            this.groupBox1.Controls.Add(this.cmbGroups);
            this.groupBox1.Controls.Add(this.cmbClients);
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 646);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panelTrack
            // 
            this.panelTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTrack.Controls.Add(this.btnPlay);
            this.panelTrack.Controls.Add(this.btnHistory);
            this.panelTrack.Controls.Add(this.btnDrawTrack);
            this.panelTrack.Controls.Add(this.dgvLatLongList);
            this.panelTrack.Controls.Add(this.mCalTripRange);
            this.panelTrack.Location = new System.Drawing.Point(793, 51);
            this.panelTrack.Name = "panelTrack";
            this.panelTrack.Size = new System.Drawing.Size(277, 639);
            this.panelTrack.TabIndex = 12;
            // 
            // dgvLatLongList
            // 
            this.dgvLatLongList.AllowUserToAddRows = false;
            this.dgvLatLongList.AllowUserToDeleteRows = false;
            this.dgvLatLongList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLatLongList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLatLongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLatLongList.Location = new System.Drawing.Point(9, 183);
            this.dgvLatLongList.Name = "dgvLatLongList";
            this.dgvLatLongList.ReadOnly = true;
            this.dgvLatLongList.RowHeadersVisible = false;
            this.dgvLatLongList.Size = new System.Drawing.Size(259, 408);
            this.dgvLatLongList.TabIndex = 4;
            // 
            // mCalTripRange
            // 
            this.mCalTripRange.Location = new System.Drawing.Point(32, 9);
            this.mCalTripRange.MaxSelectionCount = 20;
            this.mCalTripRange.Name = "mCalTripRange";
            this.mCalTripRange.ShowToday = false;
            this.mCalTripRange.ShowTodayCircle = false;
            this.mCalTripRange.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(504, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 18;
            // 
            // webBrowserTrack
            // 
            this.webBrowserTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserTrack.Location = new System.Drawing.Point(0, 0);
            this.webBrowserTrack.Size = new System.Drawing.Size(1070, 690);
            this.webBrowserTrack.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(568, 668);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Notification Received";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slide
            // 
            this.slide.Location = new System.Drawing.Point(473, 680);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(75, 23);
            this.slide.TabIndex = 23;
            this.slide.UseVisualStyleBackColor = true;
            this.slide.Click += new System.EventHandler(this.slide_Click);
            // 
            // panelPlayButtons
            // 
            this.panelPlayButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelPlayButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayButtons.Controls.Add(this.btnSlow);
            this.panelPlayButtons.Controls.Add(this.btnStop);
            this.panelPlayButtons.Controls.Add(this.btnFastPlay);
            this.panelPlayButtons.Location = new System.Drawing.Point(424, 610);
            this.panelPlayButtons.Name = "panelPlayButtons";
            this.panelPlayButtons.Size = new System.Drawing.Size(203, 55);
            this.panelPlayButtons.TabIndex = 8;
            // 
            // listViewObjectDetails
            // 
            this.listViewObjectDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewObjectDetails.Location = new System.Drawing.Point(399, 188);
            this.listViewObjectDetails.Name = "listViewObjectDetails";
            this.listViewObjectDetails.Size = new System.Drawing.Size(262, 144);
            this.listViewObjectDetails.TabIndex = 26;
            this.listViewObjectDetails.UseCompatibleStateImageBehavior = false;
            this.listViewObjectDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 129;
            // 
            // btnAppClose
            // 
            this.btnAppClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppClose.BackgroundImage = global::Tracking_Objects.Properties.Resources._100x30;
            this.btnAppClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppClose.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAppClose.Location = new System.Drawing.Point(986, 5);
            this.btnAppClose.Name = "btnAppClose";
            this.btnAppClose.Size = new System.Drawing.Size(84, 36);
            this.btnAppClose.TabIndex = 28;
            this.btnAppClose.Text = "Close";
            this.btnAppClose.UseVisualStyleBackColor = true;
            this.btnAppClose.Click += new System.EventHandler(this.btnAppClose_Click);
            // 
            // btnObjectDetails
            // 
            this.btnObjectDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObjectDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnObjectDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObjectDetails.BackgroundImage")));
            this.btnObjectDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObjectDetails.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnObjectDetails.Location = new System.Drawing.Point(629, 5);
            this.btnObjectDetails.Name = "btnObjectDetails";
            this.btnObjectDetails.Size = new System.Drawing.Size(84, 36);
            this.btnObjectDetails.TabIndex = 27;
            this.btnObjectDetails.Text = "Object Details";
            this.btnObjectDetails.UseVisualStyleBackColor = false;
            this.btnObjectDetails.Click += new System.EventHandler(this.btnObjectDetails_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotification.BackColor = System.Drawing.Color.Transparent;
            this.btnNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotification.BackgroundImage")));
            this.btnNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotification.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnNotification.Location = new System.Drawing.Point(719, 5);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(84, 36);
            this.btnNotification.TabIndex = 24;
            this.btnNotification.Text = "Notifications";
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlow.BackColor = System.Drawing.Color.Transparent;
            this.btnSlow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSlow.BackgroundImage")));
            this.btnSlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlow.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSlow.Location = new System.Drawing.Point(138, 3);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(61, 48);
            this.btnSlow.TabIndex = 22;
            this.btnSlow.Text = "Slow Play";
            this.btnSlow.UseVisualStyleBackColor = false;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnStop.Location = new System.Drawing.Point(71, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 48);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFastPlay
            // 
            this.btnFastPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFastPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnFastPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFastPlay.BackgroundImage")));
            this.btnFastPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFastPlay.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFastPlay.Location = new System.Drawing.Point(4, 3);
            this.btnFastPlay.Name = "btnFastPlay";
            this.btnFastPlay.Size = new System.Drawing.Size(61, 48);
            this.btnFastPlay.TabIndex = 20;
            this.btnFastPlay.Text = "Fast Play";
            this.btnFastPlay.UseVisualStyleBackColor = false;
            this.btnFastPlay.Click += new System.EventHandler(this.btnFastPlay_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackgroundImage = global::Tracking_Objects.Properties.Resources.button;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSettings.Location = new System.Drawing.Point(899, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 36);
            this.btnSettings.TabIndex = 21;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTrackSlide
            // 
            this.btnTrackSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrackSlide.BackColor = System.Drawing.Color.Transparent;
            this.btnTrackSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrackSlide.BackgroundImage")));
            this.btnTrackSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrackSlide.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnTrackSlide.Location = new System.Drawing.Point(809, 5);
            this.btnTrackSlide.Name = "btnTrackSlide";
            this.btnTrackSlide.Size = new System.Drawing.Size(84, 36);
            this.btnTrackSlide.TabIndex = 13;
            this.btnTrackSlide.Text = "Tracker";
            this.btnTrackSlide.UseVisualStyleBackColor = false;
            this.btnTrackSlide.Click += new System.EventHandler(this.btnTrackSlide_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPlay.Location = new System.Drawing.Point(4, 597);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(84, 36);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play Track";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnHistory.Location = new System.Drawing.Point(94, 597);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(84, 36);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "Track Hsitory";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnDrawTrack
            // 
            this.btnDrawTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrawTrack.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDrawTrack.BackgroundImage")));
            this.btnDrawTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrawTrack.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnDrawTrack.Location = new System.Drawing.Point(184, 597);
            this.btnDrawTrack.Name = "btnDrawTrack";
            this.btnDrawTrack.Size = new System.Drawing.Size(84, 36);
            this.btnDrawTrack.TabIndex = 5;
            this.btnDrawTrack.Text = "Track Object";
            this.btnDrawTrack.UseVisualStyleBackColor = false;
            this.btnDrawTrack.Click += new System.EventHandler(this.btnDrawTrack_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.Color.Transparent;
            this.btnSlide.BackgroundImage = global::Tracking_Objects.Properties.Resources.menu_start_taskbar_and_window_panel_list_512;
            this.btnSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlide.Location = new System.Drawing.Point(6, 6);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(29, 29);
            this.btnSlide.TabIndex = 10;
            this.btnSlide.UseVisualStyleBackColor = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // btnSlide1
            // 
            this.btnSlide1.BackColor = System.Drawing.Color.Transparent;
            this.btnSlide1.BackgroundImage = global::Tracking_Objects.Properties.Resources.ExpandContractPreview;
            this.btnSlide1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlide1.Location = new System.Drawing.Point(230, 19);
            this.btnSlide1.Name = "btnSlide1";
            this.btnSlide1.Size = new System.Drawing.Size(35, 29);
            this.btnSlide1.TabIndex = 12;
            this.btnSlide1.UseVisualStyleBackColor = false;
            this.btnSlide1.Click += new System.EventHandler(this.btnSlide1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tracking_Objects.Properties.Resources.tel__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 51);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 690);
            this.Controls.Add(this.btnAppClose);
            this.Controls.Add(this.btnObjectDetails);
            this.Controls.Add(this.listViewObjectDetails);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.panelPlayButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrackSlide);
            this.Controls.Add(this.panelTrack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowserTrack);
            this.Controls.Add(this.slide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAVL Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelTrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLatLongList)).EndInit();
            this.panelPlayButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSlide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.DataGridView dgvObjectList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSlide1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelTrack;
        private System.Windows.Forms.MonthCalendar mCalTripRange;
        private System.Windows.Forms.Button btnTrackSlide;
        private System.Windows.Forms.DataGridView dgvLatLongList;
        private System.Windows.Forms.Button btnDrawTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHistory;
        private Awesomium.Windows.Forms.WebControl webBrowserTrack;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFastPlay;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button slide;
        private System.Windows.Forms.Panel panelPlayButtons;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.ListView listViewObjectDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnObjectDetails;
        private System.Windows.Forms.Button btnAppClose;
    }
}

