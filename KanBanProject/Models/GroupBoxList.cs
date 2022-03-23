using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBanProject.Models
{

    public class GroupBoxList
    {
        public List<KanbanGroupBox> NewGroupBoxList;
        public GroupBoxList()
        {
            NewGroupBoxList = new List<KanbanGroupBox>();
        }
    }
}
