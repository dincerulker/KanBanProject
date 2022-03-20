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
        public TaskForm()
        {
            InitializeComponent();
        }
        TaskList taskList = null;


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kategori seçiniz!");
            }
            else
            {
                TaskClass newTask = new TaskClass();
                newTask.Acıklama = txtAciklama.Text;
                newTask.OlusturmaZamanı = DateTime.Now;
                taskList.NewTaskList.Add(newTask);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            // kaydedilmiş json dosyasından ad kısmını çekip categori isimleri olarak combobox a ekleme kodu.

            string jsonRead = File.ReadAllText("categories.json");
            dynamic array = JsonConvert.DeserializeObject<List<Category>>(jsonRead);
            foreach (var item in array)
            {
                cmbCategories.Items.Add(item.Ad);
            }
        }
    }
}
