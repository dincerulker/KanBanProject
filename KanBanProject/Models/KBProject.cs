using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBanProject.Models
{
    public class KBProject
    {
        public KBProject()
        {
            Id = Guid.NewGuid();
            OlusturmaZamani = DateTime.Now;
            Gorevler = new List<TaskClass>();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime OlusturmaZamani { get; set; }
        public List<TaskClass> Gorevler { get; set; }
    }
}
