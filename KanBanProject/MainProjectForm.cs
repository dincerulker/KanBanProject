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
    public partial class MainProjectForm : Form
    {
        private readonly KBProject kbProject;
        private readonly KanbanData kanbanData;
        
        public MainProjectForm(KBProject kbProject, KanbanData kanbanData)
        {
            InitializeComponent();
            this.kbProject = kbProject;
            this.kanbanData = kanbanData;
            lblInfo.Text = "Proje : " + kbProject.Ad + "  " + " Oluşturulma Zamanı : " + kbProject.OlusturmaZamani.ToShortDateString();

        }
        Form formHome;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.StartPosition = FormStartPosition.CenterParent;
            taskForm.ShowDialog();
            
        }
    }
}
