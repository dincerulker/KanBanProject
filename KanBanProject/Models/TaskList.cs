using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBanProject.Models
{
    public class TaskList
    {
        public List<TaskClass> NewTaskList;

        public TaskList()
        {
            NewTaskList = new List<TaskClass>();
        }
    }
}
