using KanBanProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBanProject
{

    public partial class TaskForm : Form
    {
        private readonly KBProject _kanbanProject;
        private readonly KanbanData _kanbanData;
        DraftForm draftForm = new DraftForm();

        public TaskForm(KBProject kanbanProject, KanbanData kanbanData)
        {
            InitializeComponent();
            _kanbanProject = kanbanProject;
            _kanbanData = kanbanData;
            KategorileriEkle();
            YeniSayfaOzellikleri();
        }

        private void YeniSayfaOzellikleri()
        {
            lblCharacterNumber.BackColor = Color.Green;
            draftForm.txtCreatingTime.Text = DateTime.Now.ToShortDateString();
        }

        private void KategorileriEkle()
        {
            cmbCategories.Items.Clear();
            cmbCategories.DataSource = _kanbanData.Kategoriler;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
            {
                TaskClass task = new TaskClass()
                {
                    Category = (Category)cmbCategories.SelectedItem,
                    Acıklama = txtTask.Text
                };
                _kanbanProject.Gorevler.Add(task);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter description");
                return;
            }
        }

        // kategori seçimi
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)cmbCategories.SelectedItem;
            draftForm.pnlCategoryColor.BackColor = category.Color;
            draftForm.txtTaskCategory.Text = category.Ad;
        }

        // Text 140 karakter içerisinde renk yeşil, 140 karaktere ulaşınca kırmızı olması için eklenmiştir.
        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            int characterCount = txtTask.Text.Length;
            if (characterCount < 140)
            {
                lblCharacterNumber.BackColor = Color.Green;
            }
            else
            {
                lblCharacterNumber.BackColor = Color.Red;
            }
            lblCharacterNumber.Text = "Remaining Character :" + (140 - characterCount).ToString();
            draftForm.txtTaskArea.Text = txtTask.Text;
        }        
    }
}
