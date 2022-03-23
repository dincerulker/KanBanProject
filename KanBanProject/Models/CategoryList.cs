using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBanProject.Models
{
    public class CategoryList
    {
        public List<Category> NewCategoryList;
        public CategoryList()
        {
            NewCategoryList = new List<Category>();
        }
    }
}
