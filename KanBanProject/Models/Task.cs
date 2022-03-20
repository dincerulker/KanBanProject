using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBanProject.Models
{
    public class Task
    {
        public Task()
        {
            Id = Guid.NewGuid();
            OlusturmaZamanı = DateTime.Now;
            TaskEnum = TaskEnum.Todo;

        }
        public Guid Id { get; set; }
        public string Acıklama { get; set; }
        public DateTime OlusturmaZamanı { get; set; }
        public TaskEnum TaskEnum { get; set; }
        public Category Category { get; set; }

    }
}
