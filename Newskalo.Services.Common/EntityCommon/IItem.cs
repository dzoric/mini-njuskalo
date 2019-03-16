using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Service.Common.EntityCommon
{
    public interface IItem
    {
        int Id { get; set; }
        Make Make { get; set; }
        Model Model { get; set; }
        Location Location { get; set; }
        decimal Price { get; set; }
        int YearMade { get; set; }
        int KmPassed { get; set; }
        Engine Engine { get; set; }
        Condition Condition { get; set; }
        string Picture { get; set; }
        string Description { get; set; }
    }
}
