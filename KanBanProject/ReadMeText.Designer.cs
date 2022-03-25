namespace KanBanProject
{
    partial class ReadMeText
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
            this.lblMustafa = new System.Windows.Forms.LinkLabel();
            this.lblFurkan = new System.Windows.Forms.LinkLabel();
            this.lblAhmet = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMustafa
            // 
            this.lblMustafa.AutoSize = true;
            this.lblMustafa.Location = new System.Drawing.Point(61, 128);
            this.lblMustafa.Name = "lblMustafa";
            this.lblMustafa.Size = new System.Drawing.Size(78, 13);
            this.lblMustafa.TabIndex = 1;
            this.lblMustafa.TabStop = true;
            this.lblMustafa.Text = "Mustafa Yılmaz";
            this.lblMustafa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMustafa_LinkClicked);
            // 
            // lblFurkan
            // 
            this.lblFurkan.AutoSize = true;
            this.lblFurkan.Location = new System.Drawing.Point(62, 153);
            this.lblFurkan.Name = "lblFurkan";
            this.lblFurkan.Size = new System.Drawing.Size(77, 13);
            this.lblFurkan.TabIndex = 1;
            this.lblFurkan.TabStop = true;
            this.lblFurkan.Text = "Furkan Erciyas";
            this.lblFurkan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFurkan_LinkClicked);
            // 
            // lblAhmet
            // 
            this.lblAhmet.AutoSize = true;
            this.lblAhmet.Location = new System.Drawing.Point(61, 178);
            this.lblAhmet.Name = "lblAhmet";
            this.lblAhmet.Size = new System.Drawing.Size(78, 13);
            this.lblAhmet.TabIndex = 1;
            this.lblAhmet.TabStop = true;
            this.lblAhmet.Text = "Ahmet Saıkaya";
            this.lblAhmet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAhmet_LinkClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 106);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proje yapım aşamasında gerekli noktalarda emeğini ve fikirlerini esirgemeyen isim" +
    "ler aşağıdadır.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teşekkürler..";
            // 
            // ReadMeText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAhmet);
            this.Controls.Add(this.lblFurkan);
            this.Controls.Add(this.lblMustafa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReadMeText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReadMeText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblMustafa;
        private System.Windows.Forms.LinkLabel lblFurkan;
        private System.Windows.Forms.LinkLabel lblAhmet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}