using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Common.Parameters
{
    public interface IPageParameters
    {
        int Page { get; set; }
        int PageSize { get; set; }
    }
}
