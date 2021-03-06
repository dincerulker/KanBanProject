
namespace KanBanProject
{
    partial class MainProjectForm
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
            this.flpInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDone = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTodoCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInProgressCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoneCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTodo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpInProgress
            // 
            this.flpInProgress.AllowDrop = true;
            this.flpInProgress.AutoScroll = true;
            this.flpInProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInProgress.Location = new System.Drawing.Point(284, 67);
            this.flpInProgress.Name = "flpInProgress";
            this.flpInProgress.Size = new System.Drawing.Size(266, 371);
            this.flpInProgress.TabIndex = 8;
            this.flpInProgress.WrapContents = false;
            this.flpInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpInProgress_DragDrop);
            this.flpInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpInProgress_DragEnter);
            // 
            // flpDone
            // 
            this.flpDone.AllowDrop = true;
            this.flpDone.AutoScroll = true;
            this.flpDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDone.Location = new System.Drawing.Point(556, 67);
            this.flpDone.Name = "flpDone";
            this.flpDone.Size = new System.Drawing.Size(266, 371);
            this.flpDone.TabIndex = 8;
            this.flpDone.WrapContents = false;
            this.flpDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDone_DragDrop);
            this.flpDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpDone_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "- TO DO -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "- IN PROGRESS -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "- DONE -";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(12, 1);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 10;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Note";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(550, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 372);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTodoCopy,
            this.tsmiInProgressCopy,
            this.tsmiDoneCopy});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.copyToolStripMenuItem.Text = "Copy ...";
            // 
            // tsmiTodoCopy
            // 
            this.tsmiTodoCopy.Name = "tsmiTodoCopy";
            this.tsmiTodoCopy.Size = new System.Drawing.Size(146, 22);
            this.tsmiTodoCopy.Text = "to ToDo";
            this.tsmiTodoCopy.Click += new System.EventHandler(this.tsmiTodoCopy_Click);
            // 
            // tsmiInProgressCopy
            // 
            this.tsmiInProgressCopy.Name = "tsmiInProgressCopy";
            this.tsmiInProgressCopy.Size = new System.Drawing.Size(146, 22);
            this.tsmiInProgressCopy.Text = "to In Progress";
            this.tsmiInProgressCopy.Click += new System.EventHandler(this.tsmiInProgressCopy_Click);
            // 
            // tsmiDoneCopy
            // 
            this.tsmiDoneCopy.Name = "tsmiDoneCopy";
            this.tsmiDoneCopy.Size = new System.Drawing.Size(146, 22);
            this.tsmiDoneCopy.Text = "to Done";
            this.tsmiDoneCopy.Click += new System.EventHandler(this.tsmiDoneCopy_Click);
            // 
            // flpTodo
            // 
            this.flpTodo.AllowDrop = true;
            this.flpTodo.AutoScroll = true;
            this.flpTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpTodo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTodo.Location = new System.Drawing.Point(12, 67);
            this.flpTodo.Name = "flpTodo";
            this.flpTodo.Size = new System.Drawing.Size(266, 371);
            this.flpTodo.TabIndex = 8;
            this.flpTodo.WrapContents = false;
            this.flpTodo.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpTodo_DragDrop);
            this.flpTodo.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpTodo_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(275, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 372);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 477);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpDone);
            this.Controls.Add(this.flpInProgress);
            this.Controls.Add(this.flpTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainProjectForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainProjectForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTodoCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiInProgressCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoneCopy;
        private System.Windows.Forms.FlowLayoutPanel flpInProgress;
        private System.Windows.Forms.FlowLayoutPanel flpDone;
        private System.Windows.Forms.FlowLayoutPanel flpTodo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}