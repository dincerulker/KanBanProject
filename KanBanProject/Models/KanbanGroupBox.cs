using KanBanProject.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBanProject.Models
{
    public class KanbanGroupBox
    {
        public int WidthSize { get; set; }
        public int HeightSize { get; set; }
        public Color GBBackColor { get; set; }
        public Color CategoryColor { get; set; }
        public Color BackColor { get; set; }
        public int ID { get; set; }
        public string TaskDetail { get; set; }
        public Guid Name { get; set; }
        public string Category { get; set; }

        public void NewGroupBox(FlowLayoutPanel flw, TaskList tskList, TaskClass tsk, GroupBoxList grpList, Color cCategoryColor, EventHandler DeleteButtonPressed = null)
        {
            KanbanGroupBox newKGP = new KanbanGroupBox();
            GroupBox newGP = new GroupBox();
            newKGP.Category = tsk.Category;
            newKGP.Name = Guid.NewGuid();
            newKGP.ID = tsk.Id;
            newGP.Name = newKGP.Name.ToString();

            if (grpList.NewGroupBoxList.Count < 1)
            {
                newKGP.WidthSize = flw.Width - 40;
            }
            else
            {
                newKGP.WidthSize = grpList.NewGroupBoxList[0].WidthSize;
            }
            newGP.Width = newKGP.WidthSize;
            newKGP.HeightSize = 260;
            newGP.Height = newKGP.HeightSize;
            newKGP.GBBackColor = Color.FromArgb(52, 97, 115);
            newGP.BackColor = newKGP.GBBackColor;
            newKGP.CategoryColor= cCategoryColor;
            Color categoryColor = newKGP.CategoryColor;

            newKGP.BackColor = Color.White;
            Color backColor = newKGP.BackColor;

            Label category = new Label();
            category.Text = newKGP.Category;
            category.Font = new Font("tahoma", 10, FontStyle.Bold);
            category.BackColor = categoryColor;
            category.Width = newGP.Width / 2;
            category.Height = 50;
            category.ForeColor = Color.White;
            category.Left = newGP.Left;
            category.TextAlign = ContentAlignment.MiddleLeft;
            newGP.Controls.Add(category);

            Label taskDetail = new Label();
            taskDetail.Text = newKGP.TaskDetail;
            taskDetail.Font = new Font("tahoma", 8, FontStyle.Regular);
            taskDetail.BackColor = backColor;
            taskDetail.Width = newGP.Width;
            taskDetail.Top = category.Bottom;
            taskDetail.Height = 120;
            taskDetail.ForeColor = Color.Black;
            taskDetail.Left = newGP.Left;
            taskDetail.TextAlign = ContentAlignment.MiddleCenter;
            newGP.Controls.Add(taskDetail);

            Label ID = new Label();
            ID.Text = $"ID: " + newKGP.ID.ToString();
            ID.Font = new Font("tahoma", 8, FontStyle.Regular);
            ID.BackColor = backColor;
            ID.Width = newGP.Width / 2;
            ID.Height = 40;
            ID.ForeColor = Color.Black;
            ID.Left = newGP.Right;
            ID.Top = taskDetail.Bottom;
            ID.TextAlign = ContentAlignment.MiddleRight;
            newGP.Controls.Add(ID);

            Button deleteButton = new Button();
            deleteButton.BackgroundImage = Resources.delete;
            deleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            deleteButton.Name = newKGP.Name.ToString();
            deleteButton.Width = 30;
            deleteButton.Height = 30;
            deleteButton.Left = newGP.Left;
            deleteButton.Top = taskDetail.Bottom;
            deleteButton.Click += DeleteButtonPressed;
            newGP.Controls.Add(deleteButton);

            grpList.NewGroupBoxList.Add(newKGP);
            flw.Controls.Add(newGP);




        }

        internal void NewGroupBox(FlowLayoutPanel flwToDo, TaskList taskList, TaskClass task, GroupBoxList grpBoxList, object colorRGBCode, Action<object, EventArgs> deleteButtonPressed)
        {
            throw new NotImplementedException();
        }
    }
}
