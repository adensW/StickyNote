namespace StickyNotes
{
    partial class NoteModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteModel));
            this.Title = new System.Windows.Forms.TextBox();
            this.DataNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorPickerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Title.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(5, 2);
            this.Title.MaxLength = 64;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(279, 35);
            this.Title.TabIndex = 0;
            this.Title.LostFocus += new System.EventHandler(this.NoteModel_LostFocus);
            this.Title.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NoteModel_MouseDoubleClick);
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoteModel_MouseDown);
            this.Title.MouseLeave += new System.EventHandler(this.NoteModel_MouseLeave);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NoteModel_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NoteModel_MouseUp);
            // 
            // DataNote
            // 
            this.DataNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.DataNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataNote.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataNote.Location = new System.Drawing.Point(5, 39);
            this.DataNote.Multiline = true;
            this.DataNote.Name = "DataNote";
            this.DataNote.ReadOnly = true;
            this.DataNote.Size = new System.Drawing.Size(280, 315);
            this.DataNote.TabIndex = 1;
            this.DataNote.LostFocus += new System.EventHandler(this.NoteModel_LostFocus);
            this.DataNote.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NoteModel_MouseDoubleClick);
            this.DataNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoteModel_MouseDown);
            this.DataNote.MouseLeave += new System.EventHandler(this.NoteModel_MouseLeave);
            this.DataNote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NoteModel_MouseMove);
            this.DataNote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NoteModel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            // 
            // ColorPickerBtn
            // 
            this.ColorPickerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPickerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.ColorPickerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ColorPickerBtn.FlatAppearance.BorderSize = 0;
            this.ColorPickerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPickerBtn.Location = new System.Drawing.Point(259, 8);
            this.ColorPickerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ColorPickerBtn.Name = "ColorPickerBtn";
            this.ColorPickerBtn.Size = new System.Drawing.Size(25, 25);
            this.ColorPickerBtn.TabIndex = 3;
            this.ColorPickerBtn.UseVisualStyleBackColor = false;
            this.ColorPickerBtn.Click += new System.EventHandler(this.ColorPickerBtn_Click);
            this.ColorPickerBtn.MouseLeave += new System.EventHandler(this.ColorPickerBtn_Hide);
            this.ColorPickerBtn.MouseHover += new System.EventHandler(this.ColorPickerBtn_Show);
            // 
            // NoteModel
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(290, 360);
            this.ControlBox = false;
            this.Controls.Add(this.ColorPickerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataNote);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteModel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NoteModel";
            this.SizeChanged += new System.EventHandler(this.ResizeAll);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox DataNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorPickerBtn;
    }
}