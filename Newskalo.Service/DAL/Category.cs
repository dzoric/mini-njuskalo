using Newskalo.Service.Common.EntityCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Service.DAL
{
    public class Category : ICategory
    {
        public int Id { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }

        public virtual ICollection<Item> Item { get; set; }

        public Category()
        {
            Item = new HashSet<Item>();
        }
    }
}
