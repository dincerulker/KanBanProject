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
            Gorevler = new List<Task>();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime OlusturmaZamani { get; set; }
        public List<Task> Gorevler { get; set; }
    }
}
