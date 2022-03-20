using KanBanProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBanProject
{
    public partial class CategoryForm : Form
    {
        public KanbanData _kanbanData;
        List<Category> categories = new List<Category>();
        public CategoryForm(KanbanData kanbanData)
        {
            InitializeComponent();
            _kanbanData = kanbanData;

        }
        
        
        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Ad = txtCategoryName.Text;
            categories.Add(cat);
            cat.ColorName = pbColor.BackColor.ToString();
            dgvCategories.DataSource = null;
            dgvCategories.DataSource = categories;
            dgvCategories.Columns["Id"].Visible = false;
            dgvCategories.Columns["Color"].Visible = false;
            txtCategoryName.Clear();
            pbColor.BackColor = Color.Red;
           
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pbColor.BackColor = colorDialog1.Color;
        }
    }
}
