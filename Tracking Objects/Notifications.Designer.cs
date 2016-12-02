namespace Tracking_Objects
{
    partial class Notifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.browserNotifTrack = new Awesomium.Windows.Forms.WebControl(this.components);
            this.webNotifTrack = new Awesomium.Windows.Forms.WebControl(this.components);
            this.btnClearNotification = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotifications.Location = new System.Drawing.Point(0, 0);
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.Size = new System.Drawing.Size(586, 507);
            this.dgvNotifications.TabIndex = 0;
            this.dgvNotifications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotifications_CellContentClick);
            this.dgvNotifications.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNotifications_CellMouseClick);
            // 
            // browserNotifTrack
            // 
            this.browserNotifTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserNotifTrack.Location = new System.Drawing.Point(0, 0);
            this.browserNotifTrack.Size = new System.Drawing.Size(586, 507);
            this.browserNotifTrack.TabIndex = 8;
            // 
            // webNotifTrack
            // 
            this.webNotifTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webNotifTrack.Location = new System.Drawing.Point(0, 0);
            this.webNotifTrack.Size = new System.Drawing.Size(586, 507);
            this.webNotifTrack.TabIndex = 10;
            // 
            // btnClearNotification
            // 
            this.btnClearNotification.BackColor = System.Drawing.Color.Transparent;
            this.btnClearNotification.BackgroundImage = global::Tracking_Objects.Properties.Resources.button;
            this.btnClearNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearNotification.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnClearNotification.Location = new System.Drawing.Point(498, 459);
            this.btnClearNotification.Name = "btnClearNotification";
            this.btnClearNotification.Size = new System.Drawing.Size(76, 36);
            this.btnClearNotification.TabIndex = 11;
            this.btnClearNotification.Text = "Clear";
            this.btnClearNotification.UseVisualStyleBackColor = false;
            this.btnClearNotification.Click += new System.EventHandler(this.btnClearNotification_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Tracking_Objects.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(498, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 507);
            this.Controls.Add(this.btnClearNotification);
            this.Controls.Add(this.webNotifTrack);
            this.Controls.Add(this.dgvNotifications);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.Notifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotifications;
        private Awesomium.Windows.Forms.WebControl browserNotifTrack;
        private Awesomium.Windows.Forms.WebControl webNotifTrack;
        private System.Windows.Forms.Button btnClearNotification;
        private System.Windows.Forms.Button button1;
    }
}