namespace StickyNotes
{
    partial class Start
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateBtn = new System.Windows.Forms.PictureBox();
            this.ManagerBtn = new System.Windows.Forms.PictureBox();
            this.SettingsBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Sticky Note";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateItem,
            this.ManagerItem,
            this.SettingItem,
            this.ExitItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 108);
            // 
            // CreateItem
            // 
            this.CreateItem.Name = "CreateItem";
            this.CreateItem.Size = new System.Drawing.Size(144, 26);
            this.CreateItem.Text = "新建便签";
            this.CreateItem.Click += new System.EventHandler(this.CreateItem_Click);
            // 
            // ManagerItem
            // 
            this.ManagerItem.Name = "ManagerItem";
            this.ManagerItem.Size = new System.Drawing.Size(144, 26);
            this.ManagerItem.Text = "查看便签";
            this.ManagerItem.Click += new System.EventHandler(this.ManagerItem_Click);
            // 
            // SettingItem
            // 
            this.SettingItem.Name = "SettingItem";
            this.SettingItem.Size = new System.Drawing.Size(144, 26);
            this.SettingItem.Text = "开机启动";
            this.SettingItem.Click += new System.EventHandler(this.SettingItem_Click);
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.Size = new System.Drawing.Size(144, 26);
            this.ExitItem.Text = "退出";
            this.ExitItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.CreateBtn);
            this.flowLayoutPanel1.Controls.Add(this.ManagerBtn);
            this.flowLayoutPanel1.Controls.Add(this.SettingsBtn);
            this.flowLayoutPanel1.Controls.Add(this.ExitBtn);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 48);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StickyNotes.Properties.Resources.note48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gPanelTitleBack_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Start_MouseUp);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Image = global::StickyNotes.Properties.Resources.ic_add_box_black_24dp_2x;
            this.CreateBtn.Location = new System.Drawing.Point(48, 0);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(48, 48);
            this.CreateBtn.TabIndex = 1;
            this.CreateBtn.TabStop = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ManagerBtn
            // 
            this.ManagerBtn.Image = global::StickyNotes.Properties.Resources.ic_storage_black_24dp_2x;
            this.ManagerBtn.Location = new System.Drawing.Point(96, 0);
            this.ManagerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ManagerBtn.Name = "ManagerBtn";
            this.ManagerBtn.Size = new System.Drawing.Size(48, 48);
            this.ManagerBtn.TabIndex = 2;
            this.ManagerBtn.TabStop = false;
            this.ManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsBtn.Image = global::StickyNotes.Properties.Resources.ic_settings_black_24dp_2x;
            this.SettingsBtn.Location = new System.Drawing.Point(144, 0);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(48, 48);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.TabStop = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = global::StickyNotes.Properties.Resources.ic_close_black_24dp_2x;
            this.ExitBtn.Location = new System.Drawing.Point(192, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(48, 48);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(240, 48);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sticky Notes";
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

      
        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateItem;
        private System.Windows.Forms.ToolStripMenuItem ManagerItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CreateBtn;
        private System.Windows.Forms.PictureBox ManagerBtn;
        private System.Windows.Forms.PictureBox SettingsBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.ToolStripMenuItem SettingItem;
    }
}

