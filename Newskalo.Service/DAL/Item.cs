using Newskalo.Service.Common.EntityCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Service.DAL
{
    public class Item : IItem
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
        public Location Location { get; set; }
        public decimal Price { get; set; }
        public int YearMade { get; set; }
        public int KmPassed { get; set; }
        public Engine Engine { get; set; }
        public Condition Condition { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
