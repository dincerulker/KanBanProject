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
    public partial class MainProjectForm : Form
    {
        
        private readonly KBProject _kbProject;
        private readonly KanbanData _kanbanData;
        public MainProjectForm(KBProject kbProject, KanbanData kanbanData)
        {
            InitializeComponent();
            _kbProject = kbProject;
            _kanbanData = kanbanData;
            BilgileriYazdir(kbProject);
            ShowPanels();
        }

        private void BilgileriYazdir(KBProject kbProject)
        {
            lblInfo.Text = "Proje : " + kbProject.Ad + "  " + " Oluşturulma Zamanı : " + kbProject.OlusturmaZamani.ToShortDateString();
        }
        private void ShowPanels()
        {
            TodoList();
            InProggressList();
            DoneList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{_kbProject.Ad} will be permanently deleted, are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _kanbanData.Projeler.Remove(_kbProject);
                Close();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btnDelete = sender as Button;
            Guid guid = (Guid)btnDelete.Tag;
            TaskClass deletedTask = _kbProject.Gorevler.FirstOrDefault(x => x.Id == guid);
            _kbProject.Gorevler.Remove(deletedTask);
            ShowPanels();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(_kbProject, _kanbanData);
            taskForm.StartPosition = FormStartPosition.CenterParent;
            taskForm.ShowDialog();
            ShowPanels();
        }

        private void DoneList()
        {
            flpDone.Controls.Clear();

            List<TaskClass> DoneTask = _kbProject.Gorevler.Where(x => x.TaskEnum == TaskEnum.Done).ToList();

            for (int i = 0; i < DoneTask.Count; i++)
            {
                DraftForm draftForm = new DraftForm();
                flpDone.Controls.Add(draftForm.pnlCategoryColor);
                draftForm.pnlCategoryColor.BackColor = DoneTask[i].Category.Color;
                draftForm.pnlCategoryColor.Top = (i * draftForm.pnlCategoryColor.Height) + 10;
                draftForm.pnlCategoryColor.Left = (flpDone.Width - draftForm.pnlCategoryColor.Width) / 2;
                draftForm.txtTaskCategory.Text = DoneTask[i].Category.ToString();
                draftForm.txtTaskArea.Text = DoneTask[i].Acıklama.ToString();
                draftForm.txtCreatingTime.Text = DoneTask[i].OlusturmaZamanı.ToString();
                draftForm.btnDelete.Click += BtnDelete_Click;
                draftForm.btnDelete.Tag = DoneTask[i].Id;
                draftForm.pnlCategoryColor.MouseDown += PnlCategoryColor_MouseDown;
                draftForm.pnlCategoryColor.Tag = DoneTask[i].Id;
            }
        }
        private void InProggressList()
        {
            flpInProgress.Controls.Clear();

            List<TaskClass> InProgressTask = _kbProject.Gorevler.Where(x => x.TaskEnum == TaskEnum.InProgress).ToList();

            for (int i = 0; i < InProgressTask.Count; i++)
            {
                DraftForm draftForm = new DraftForm();
                flpInProgress.Controls.Add(draftForm.pnlCategoryColor);
                draftForm.pnlCategoryColor.BackColor = InProgressTask[i].Category.Color;
                draftForm.pnlCategoryColor.Top = (i * draftForm.pnlCategoryColor.Height) + 10;
                draftForm.pnlCategoryColor.Left = (flpInProgress.Width - draftForm.pnlCategoryColor.Width) / 2;
                draftForm.txtTaskCategory.Text = InProgressTask[i].Category.ToString();
                draftForm.txtTaskArea.Text = InProgressTask[i].Acıklama.ToString();
                draftForm.txtCreatingTime.Text = InProgressTask[i].OlusturmaZamanı.ToString();
                draftForm.btnDelete.Click += BtnDelete_Click;
                draftForm.btnDelete.Tag = InProgressTask[i].Id;
                draftForm.pnlCategoryColor.MouseDown += PnlCategoryColor_MouseDown;
                draftForm.pnlCategoryColor.Tag = InProgressTask[i].Id;
            }
        }
        private void TodoList()
        {
            flpTodo.Controls.Clear();

            List<TaskClass> toDoTask = _kbProject.Gorevler.Where(x => x.TaskEnum == TaskEnum.Todo).ToList();

            for (int i = 0; i < toDoTask.Count; i++)
            {
                DraftForm draftForm = new DraftForm();
                flpTodo.Controls.Add(draftForm.pnlCategoryColor);
                draftForm.pnlCategoryColor.BackColor = toDoTask[i].Category.Color;
                draftForm.pnlCategoryColor.Top = (i * draftForm.pnlCategoryColor.Height) + 10;
                draftForm.pnlCategoryColor.Left = (flpTodo.Width - draftForm.pnlCategoryColor.Width) / 2;
                draftForm.txtTaskCategory.Text = toDoTask[i].Category.ToString();
                draftForm.txtTaskArea.Text = toDoTask[i].Acıklama.ToString();
                draftForm.txtCreatingTime.Text = toDoTask[i].OlusturmaZamanı.ToString();
                draftForm.btnDelete.Click += BtnDelete_Click;
                draftForm.btnDelete.Tag = toDoTask[i].Id;
                draftForm.pnlCategoryColor.MouseDown += PnlCategoryColor_MouseDown;
                draftForm.pnlCategoryColor.Tag = toDoTask[i].Id;
                draftForm.MouseDown += DraftForm_MouseDown;
                draftForm.pnlCategoryColor.MouseDown += PnlCategoryColor_MouseDown1;
            }
        }

        private void PnlCategoryColor_MouseDown1(object sender, MouseEventArgs e)
        {
            var mevcutForm = (Panel)sender;
            DoDragDrop(mevcutForm, DragDropEffects.Move);
        }

        private void DraftForm_MouseDown(object sender, MouseEventArgs e)
        {
            var mevcutForm = (Panel)sender;
            DoDragDrop(mevcutForm, DragDropEffects.Move);
        }

        private void PnlCategoryColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && sender is Panel)
            {
                contextMenuStrip1.Show((Panel)sender, new Point(e.X, e.Y));
                contextMenuStrip1.Tag = ((Panel)sender).Tag;
            }
        }

        private void flpTodo_DragDrop(object sender, DragEventArgs e)
        {
            Panel panel = (Panel)e.Data.GetData(typeof(Panel));
            panel.Parent.Controls.Remove(panel);
            flpTodo.Controls.Add(panel);
        }
        private void flpInProgress_DragDrop(object sender, DragEventArgs e)
        {
            Panel panel = (Panel)e.Data.GetData(typeof(Panel));
            panel.Parent.Controls.Remove(panel);
            flpInProgress.Controls.Add(panel);
        }
        private void flpDone_DragDrop(object sender, DragEventArgs e)
        {
            Panel panel = (Panel)e.Data.GetData(typeof(Panel));
            panel.Parent.Controls.Remove(panel);
            flpDone.Controls.Add(panel);
        }
        private void tsmiTodoCopy_Click(object sender, EventArgs e)
        {
            Guid guid = (Guid)contextMenuStrip1.Tag;
            TaskClass taskClass = _kbProject.Gorevler.FirstOrDefault(x => x.Id == guid);
            _kbProject.Gorevler.Add(new TaskClass()
            {
                Acıklama = taskClass.Acıklama,
                TaskEnum = TaskEnum.Todo,
                Category = taskClass.Category,
                OlusturmaZamanı = taskClass.OlusturmaZamanı
            });
            ShowPanels();
        }

        private void tsmiInProgressCopy_Click(object sender, EventArgs e)
        {
            Guid guid = (Guid)contextMenuStrip1.Tag;
            TaskClass taskClass = _kbProject.Gorevler.FirstOrDefault(x => x.Id == guid);
            _kbProject.Gorevler.Add(new TaskClass()
            {
                Acıklama = taskClass.Acıklama,
                TaskEnum = TaskEnum.InProgress,
                Category = taskClass.Category,
                OlusturmaZamanı = taskClass.OlusturmaZamanı
            });
            ShowPanels();
        }

        private void tsmiDoneCopy_Click(object sender, EventArgs e)
        {
            Guid guid = (Guid)contextMenuStrip1.Tag;
            TaskClass taskClass = _kbProject.Gorevler.FirstOrDefault(x => x.Id == guid);
            _kbProject.Gorevler.Add(new TaskClass()
            {
                Acıklama = taskClass.Acıklama,
                TaskEnum = TaskEnum.Done,
                Category = taskClass.Category,
                OlusturmaZamanı = taskClass.OlusturmaZamanı
            });
            ShowPanels();
        }
        private void flpTodo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flpInProgress_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flpDone_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void MainProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(_kanbanData);
            File.WriteAllText("task.json", json);
            
        }
    }
}
