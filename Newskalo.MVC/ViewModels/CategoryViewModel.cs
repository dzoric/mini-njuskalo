using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Newskalo.MVC.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }
    }
}