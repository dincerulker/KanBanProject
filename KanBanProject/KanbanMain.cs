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

        }

        private void tsmiAddCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(kanbanData);
            categoryForm.ShowDialog();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}
