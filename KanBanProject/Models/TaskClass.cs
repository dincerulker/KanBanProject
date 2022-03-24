using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBanProject.Models
{
    public class TaskClass
    {
        public TaskClass()
        {
            Id = Guid.NewGuid();
            OlusturmaZamanı = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Acıklama { get; set; }
        public DateTime OlusturmaZamanı { get; set; }
        public TaskEnum TaskEnum { get; set; }
        public Category Category { get; set; }
        public override string ToString()
        {
            return Acıklama;
        }
    }
}
