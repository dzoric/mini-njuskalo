using Newskalo.Common.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Common.ParametersCommon
{
    public class SortParameters : ISortParameters
    {
        public string Sort { get; set; }
        public string Direction { get; set; }
    }
}
