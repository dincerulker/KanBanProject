using DocumentFormat.OpenXml.Drawing.Diagrams;
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
using Category = KanBanProject.Models.Category;

namespace KanBanProject
{
    public partial class CategoryForm : Form
    {
        private readonly KanbanData _kanbanData;
        public List<Category> categories = new List<Category>();
        public CategoryForm(KanbanData kanbanData)
        {
            InitializeComponent();
            _kanbanData = kanbanData;
            Category category = new Category();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // sayfanın çıkış butonunu kapatıldı, çıkmak için buton eklendi.
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "") // categori ismi boş olursa ekleme yapmayacak
            {
                _kanbanData.Kategoriler.Add(new Category()
                {
                    Ad = txtCategoryName.Text,
                    Color = pbColor.BackColor
                });
                txtCategoryName.Clear();
                pbColor.BackColor = Color.Black;
                KategorileriYukle();
            }
        }

        private void KategorileriYukle()
        {
            lstCategories.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(25, 25);
            lstCategories.SmallImageList = imageList;
            foreach (Category item in _kanbanData.Kategoriler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = item.Ad + item.Id;
                lvi.Text = item.Ad;
                lvi.Tag = item.Id;
                Bitmap bitmap = new Bitmap(25, 25);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        bitmap.SetPixel(i, j, item.Color);
                    }
                }
                imageList.Images.Add(item.Ad,bitmap);
                lvi.ImageKey = item.Ad;
                lstCategories.Items.Add(lvi);
            }
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pbColor.BackColor = colorDialog1.Color;
        }

        private void lstCategories_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
