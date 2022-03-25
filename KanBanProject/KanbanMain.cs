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
    public partial class MainForm : Form
    {
        KanbanData kanbanData;
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            kanbanData = new KanbanData();
            ListeyiDoldur();
                       
        }

        private void tsmiNewTask_Click(object sender, EventArgs e)
        {
            KBProject kBProject = new KBProject();
            NewTaskForm newTaskForm = new NewTaskForm(kBProject);
            DialogResult dr = newTaskForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MainProjectForm mainProjectForm = new MainProjectForm(kBProject, kanbanData);
                kanbanData.Projeler.Add(kBProject);
                mainProjectForm.MdiParent = this;
                mainProjectForm.Show();
            }
            ListeyiDoldur();
        }

        private void ProjeyiListele()
        {
            ClearForm();
            foreach (var item in kanbanData.Projeler)
            {
                MainProjectForm mainProjectForm = new MainProjectForm(item, kanbanData);
                mainProjectForm.MdiParent = this;
                mainProjectForm.Show();
            }            
        }

        private void tsmiAddCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(kanbanData);
            categoryForm.ShowDialog();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh(); // Proje ekranı büyüdüğünde eklenen resmin tam görünmesi için sayfayı yeniledik.
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(kanbanData);
            File.WriteAllText("project.json", json);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
            try
            {
                string json = File.ReadAllText("project.json");
                kanbanData = JsonConvert.DeserializeObject<KanbanData>(json);
            }
            catch (Exception)
            {

                kanbanData = new KanbanData();
            }
        }
        // Eski projeyi açmak için combobox'a tıklandığında eski projeleri yükler.
        private void tscTask_Click(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void tscTask_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (tscTask.SelectedIndex == 0)
            {
                ClearForm();   
            }
            else if (tscTask.SelectedIndex == 1)
            {
                ProjeyiListele();
            }
            else
            {
                ClearForm();
                KBProject selected = (KBProject)tscTask.SelectedItem;
                KBProject kBProject = new KBProject()
                {
                    Id = selected.Id,
                    Ad = selected.Ad,
                    Gorevler = selected.Gorevler,
                    OlusturmaZamani = selected.OlusturmaZamani,
                };
                MainProjectForm mainProjectForm = new MainProjectForm(kBProject, kanbanData);
                mainProjectForm.MdiParent = this;
                mainProjectForm.Show();
            }
        }

        private void ClearForm()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Dispose();
                item.Close();
            }
        }

        private void ListeyiDoldur()
        {
            tscTask.Items.Clear();
            tscTask.Items.Add("KanBan Main Page");
            tscTask.Items.Add("All Project");
            foreach (KBProject item in kanbanData.Projeler)
            {
                tscTask.Items.Add(item);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ReadMeText readMeText = new ReadMeText();
            readMeText.MdiParent = this;
            readMeText.Show();
        }

        // Tıklandığında gerekli sayfa açılıyor
        
        private void lblDincerUlker_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dincerulker");
        }

        
    }
}
