using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Service.Common.EntityCommon
{
    public interface ICategory
    {
        int Id { get; set; }
        string CategoryTitle { get; set; }
        string CategoryDescription { get; set; }
        string CategoryImage { get; set; }
    }
}
