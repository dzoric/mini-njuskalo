using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Common.Parameters
{
    public interface ISortParameters
    {
        string Sort { get; set; }
        string Direction { get; set; }
    }
}
