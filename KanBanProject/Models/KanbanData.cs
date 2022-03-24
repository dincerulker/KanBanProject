using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBanProject.Models
{
    public class KanbanData
    {
        public KanbanData()
        {
            Projeler = new List<KBProject>();
            Kategoriler = new List<Category>();
        }
        public List<KBProject> Projeler { get; set; }
        public List<Category> Kategoriler { get; set; }
    }
}
