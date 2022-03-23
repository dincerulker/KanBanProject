
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

namespace KanbanHY
{
    public partial class FormNewTask : Form
    {
        public FormNewTask()
        {
            InitializeComponent();
        }

        TaskList taskList = null;
        string formName = null;
        FlowLayoutPanel flwDone = null;
        FlowLayoutPanel flwInProgress = null;
        FlowLayoutPanel flwToDo = null;
        GroupBoxList grpList = null;
        KanbanGroupBox newKGP = new KanbanGroupBox();
        FormBoard formBoard = null;
        Panel pnlHome = null;
        Panel pnlBackground = null;
        CategoryList categoryList = null;
        EventHandler DeleteButtonPressed = null;
        public FormNewTask(TaskList cTaskList, string cformName, FlowLayoutPanel cflwDone, FlowLayoutPanel cflwInProgress, FlowLayoutPanel cflwToDo, GroupBoxList cgrpList, FormBoard cformBoard, Panel cpnlHome, CategoryList cCategoryList, Panel cpnlBackground, EventHandler cDeleteButtonPressed)
        {
            InitializeComponent();
            taskList = cTaskList;
            formName = cformName;
            flwDone = cflwDone;
            flwInProgress = cflwInProgress;
            flwToDo = cflwToDo;
            grpList = cgrpList;
            formBoard = cformBoard;
            pnlHome = cpnlHome;
            categoryList = cCategoryList;
            pnlBackground = cpnlBackground;
            DeleteButtonPressed = cDeleteButtonPressed;
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {

            if (cmbCategories.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
            }
            
            else if (String.IsNullOrEmpty(txtTaskDetails.Text))
            {
                MessageBox.Show("Please write task details.");
            }
            else
            {
                TaskClass newTask = new TaskClass();
                newTask.Acıklama = txtTaskDetails.Text;
                
                
                newTask.OlusturmaZamanı = DateTime.Now;
                newTask.Category = cmbCategories.Text;
                
                taskList.NewTaskList.Add(newTask);

                for (int i = 0; i < taskList.NewTaskList.Count; i++)
                {
                    taskList.NewTaskList[i].Id = i + 1;
                }

                var selectedCategory = categoryList.NewCategoryList.Find(x => x.Ad == cmbCategories.Text);

                if (formName == "ToDo")
                {
                    newKGP.NewGroupBox(flwToDo, taskList, newTask, grpList, selectedCategory.Color, DeleteButtonPressed);
                }
                else if (formName == "Done")
                {
                    newKGP.NewGroupBox(flwDone, taskList, newTask, grpList, selectedCategory.Color, DeleteButtonPressed);
                }

                else
                {
                    newKGP.NewGroupBox(flwInProgress, taskList, newTask, grpList, selectedCategory.Color, DeleteButtonPressed);
                }

                pnlHome.Visible = true;
                pnlBackground.Visible = true;
                formBoard.Visible = true;

                this.Close();
            }
        }

        private void FormNewTask_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(147, 183, 191);

            if (formName == "ToDo")
                rdoToDo.Checked = true;
            else if (formName == "Done")
                rdoDone.Checked = true;
            else
                rdoInProgress.Checked = true;

            if (formName == "ToDo")
            {
                rdoToDo.Checked = true;
                rdoInProgress.Enabled = false;
                rdoDone.Enabled = false;
            }
            else if (formName == "Done")
            {
                rdoToDo.Enabled = false;
                rdoInProgress.Enabled = false;
                rdoDone.Checked = true;
            }

            else
            {
                rdoToDo.Enabled = false;
                rdoInProgress.Checked = true;
                rdoDone.Enabled = false;
            }

            foreach (var item in categoryList.NewCategoryList)
            {
                cmbCategories.Items.Add(item.Ad);
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = true;
            pnlBackground.Visible = true;
            formBoard.Visible = true;
            this.Close();
        }
    }
}
