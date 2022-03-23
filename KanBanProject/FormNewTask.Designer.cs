namespace KanbanHY
{
    partial class FormNewTask
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.txtTaskDetails = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.rdoDone = new System.Windows.Forms.RadioButton();
            this.rdoInProgress = new System.Windows.Forms.RadioButton();
            this.rdoToDo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(273, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 31);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(155, 334);
            this.btnNewTask.Margin = new System.Windows.Forms.Padding(1);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(64, 29);
            this.btnNewTask.TabIndex = 20;
            this.btnNewTask.Text = "Save";
            this.btnNewTask.UseVisualStyleBackColor = true;
            // 
            // txtTaskDetails
            // 
            this.txtTaskDetails.Location = new System.Drawing.Point(24, 266);
            this.txtTaskDetails.Margin = new System.Windows.Forms.Padding(1);
            this.txtTaskDetails.Multiline = true;
            this.txtTaskDetails.Name = "txtTaskDetails";
            this.txtTaskDetails.Size = new System.Drawing.Size(198, 59);
            this.txtTaskDetails.TabIndex = 19;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(24, 124);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(1);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(166, 21);
            this.cmbCategories.TabIndex = 16;
            // 
            // rdoDone
            // 
            this.rdoDone.AutoSize = true;
            this.rdoDone.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDone.ForeColor = System.Drawing.Color.Black;
            this.rdoDone.Location = new System.Drawing.Point(169, 83);
            this.rdoDone.Margin = new System.Windows.Forms.Padding(1);
            this.rdoDone.Name = "rdoDone";
            this.rdoDone.Size = new System.Drawing.Size(50, 17);
            this.rdoDone.TabIndex = 13;
            this.rdoDone.TabStop = true;
            this.rdoDone.Text = "Done";
            this.rdoDone.UseVisualStyleBackColor = true;
            // 
            // rdoInProgress
            // 
            this.rdoInProgress.AutoSize = true;
            this.rdoInProgress.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInProgress.ForeColor = System.Drawing.Color.Black;
            this.rdoInProgress.Location = new System.Drawing.Point(84, 83);
            this.rdoInProgress.Margin = new System.Windows.Forms.Padding(1);
            this.rdoInProgress.Name = "rdoInProgress";
            this.rdoInProgress.Size = new System.Drawing.Size(80, 17);
            this.rdoInProgress.TabIndex = 14;
            this.rdoInProgress.TabStop = true;
            this.rdoInProgress.Text = "In Progress";
            this.rdoInProgress.UseVisualStyleBackColor = true;
            // 
            // rdoToDo
            // 
            this.rdoToDo.AutoSize = true;
            this.rdoToDo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoToDo.ForeColor = System.Drawing.Color.Black;
            this.rdoToDo.Location = new System.Drawing.Point(24, 83);
            this.rdoToDo.Margin = new System.Windows.Forms.Padding(1);
            this.rdoToDo.Name = "rdoToDo";
            this.rdoToDo.Size = new System.Drawing.Size(53, 17);
            this.rdoToDo.TabIndex = 15;
            this.rdoToDo.TabStop = true;
            this.rdoToDo.Text = "To Do";
            this.rdoToDo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Top Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Task Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sub Category";
            // 
            // FormNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewTask);
            this.Controls.Add(this.txtTaskDetails);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.rdoDone);
            this.Controls.Add(this.rdoInProgress);
            this.Controls.Add(this.rdoToDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.TextBox txtTaskDetails;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.RadioButton rdoDone;
        private System.Windows.Forms.RadioButton rdoInProgress;
        private System.Windows.Forms.RadioButton rdoToDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}