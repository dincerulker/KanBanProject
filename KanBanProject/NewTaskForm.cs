
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
    public partial class NewTaskForm : Form
    {
        private readonly KBProject kBProject;       

        public NewTaskForm(KBProject kBProject)
        {
            InitializeComponent();
            this.kBProject = kBProject;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTask.Text == "")
            {
                MessageBox.Show("Task bölümü boş geçilemez");
                return;
            }            
            this.kBProject.Ad = txtTask.Text;            
            this.Close();
        }
    }
}
