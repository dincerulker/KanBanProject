namespace KanBanProject
{
    partial class DraftForm
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
            this.txtTaskCategory = new System.Windows.Forms.TextBox();
            this.txtCreatingTime = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTaskArea = new System.Windows.Forms.TextBox();
            this.pnlCategoryColor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCategoryColor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaskCategory
            // 
            this.txtTaskCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTaskCategory.Location = new System.Drawing.Point(9, 15);
            this.txtTaskCategory.Name = "txtTaskCategory";
            this.txtTaskCategory.Size = new System.Drawing.Size(233, 26);
            this.txtTaskCategory.TabIndex = 0;
            // 
            // txtCreatingTime
            // 
            this.txtCreatingTime.Location = new System.Drawing.Point(9, 262);
            this.txtCreatingTime.Name = "txtCreatingTime";
            this.txtCreatingTime.Size = new System.Drawing.Size(188, 20);
            this.txtCreatingTime.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::KanBanProject.Properties.Resources.delete__1_;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(203, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtTaskArea
            // 
            this.txtTaskArea.Location = new System.Drawing.Point(9, 48);
            this.txtTaskArea.Multiline = true;
            this.txtTaskArea.Name = "txtTaskArea";
            this.txtTaskArea.Size = new System.Drawing.Size(233, 188);
            this.txtTaskArea.TabIndex = 9;
            // 
            // pnlCategoryColor
            // 
            
            this.pnlCategoryColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCategoryColor.Controls.Add(this.txtTaskArea);
            this.pnlCategoryColor.Controls.Add(this.txtTaskCategory);
            this.pnlCategoryColor.Controls.Add(this.txtCreatingTime);
            this.pnlCategoryColor.Controls.Add(this.btnDelete);
            this.pnlCategoryColor.Location = new System.Drawing.Point(10, 19);
            this.pnlCategoryColor.Name = "pnlCategoryColor";
            this.pnlCategoryColor.Size = new System.Drawing.Size(250, 294);
            this.pnlCategoryColor.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlCategoryColor);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 326);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // DraftForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 338);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DraftForm";
            this.Text = "DraftForm";
            this.pnlCategoryColor.ResumeLayout(false);
            this.pnlCategoryColor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtTaskCategory;
        public System.Windows.Forms.TextBox txtCreatingTime;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtTaskArea;
        public System.Windows.Forms.Panel pnlCategoryColor;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}