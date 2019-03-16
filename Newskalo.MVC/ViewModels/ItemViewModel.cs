using Newskalo.Service.Common.EntityCommon;
using Newskalo.Service.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Newskalo.MVC.ViewModels
{
    public class ItemViewModel
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
    }
}