namespace StickyNotes
{
    partial class DataIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataIO));
            this.Title = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("宋体", 18F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(280, 35);
            this.Title.TabIndex = 0;
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Note.Font = new System.Drawing.Font("宋体", 12F);
            this.Note.Location = new System.Drawing.Point(0, 35);
            this.Note.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(280, 315);
            this.Note.TabIndex = 1;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(10, 350);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(80, 35);
            this.ConfirmBtn.TabIndex = 2;
            this.ConfirmBtn.Text = "确认";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(100, 350);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(80, 35);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            this.ResetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(190, 350);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(80, 35);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "重置";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 35);
            this.panel1.TabIndex = 5;
            // 
            // DataIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(280, 385);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.Note);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataIO";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sticky Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataIO_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Panel panel1;
    }
}