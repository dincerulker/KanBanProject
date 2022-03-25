namespace KanBanProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiNewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.olderTaskToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.tscTask = new System.Windows.Forms.ToolStripComboBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblDincerUlker = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewTask,
            this.tsmiAddCategory,
            this.olderTaskToolStripMenuItem,
            this.tscTask});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiNewTask
            // 
            this.tsmiNewTask.Name = "tsmiNewTask";
            this.tsmiNewTask.Size = new System.Drawing.Size(83, 23);
            this.tsmiNewTask.Text = "New Project";
            this.tsmiNewTask.Click += new System.EventHandler(this.tsmiNewTask_Click);
            // 
            // tsmiAddCategory
            // 
            this.tsmiAddCategory.Name = "tsmiAddCategory";
            this.tsmiAddCategory.Size = new System.Drawing.Size(92, 23);
            this.tsmiAddCategory.Text = "Add Category";
            this.tsmiAddCategory.Click += new System.EventHandler(this.tsmiAddCategory_Click);
            // 
            // olderTaskToolStripMenuItem
            // 
            this.olderTaskToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.olderTaskToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.olderTaskToolStripMenuItem.Name = "olderTaskToolStripMenuItem";
            this.olderTaskToolStripMenuItem.ReadOnly = true;
            this.olderTaskToolStripMenuItem.ShortcutsEnabled = false;
            this.olderTaskToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.olderTaskToolStripMenuItem.Text = "Older Task";
            // 
            // tscTask
            // 
            this.tscTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscTask.Name = "tscTask";
            this.tscTask.Size = new System.Drawing.Size(200, 23);
            this.tscTask.SelectedIndexChanged += new System.EventHandler(this.tscTask_SelectedIndexChanged);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::KanBanProject.Properties.Resources.info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(990, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 25);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblDincerUlker
            // 
            this.lblDincerUlker.AutoSize = true;
            this.lblDincerUlker.LinkColor = System.Drawing.Color.Red;
            this.lblDincerUlker.Location = new System.Drawing.Point(865, 6);
            this.lblDincerUlker.Name = "lblDincerUlker";
            this.lblDincerUlker.Size = new System.Drawing.Size(119, 13);
            this.lblDincerUlker.TabIndex = 5;
            this.lblDincerUlker.TabStop = true;
            this.lblDincerUlker.Text = "created by Dinçer Ülker";
            this.lblDincerUlker.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDincerUlker_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::KanBanProject.Properties.Resources.kanbanpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 559);
            this.Controls.Add(this.lblDincerUlker);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1031, 598);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanBanBoard v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTask;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCategory;
        private System.Windows.Forms.ToolStripComboBox tscTask;
        private System.Windows.Forms.ToolStripTextBox olderTaskToolStripMenuItem;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.LinkLabel lblDincerUlker;
    }
}

