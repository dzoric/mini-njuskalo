using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Service.Common.EntityCommon
{ 
    public enum Make
    {
        BMW = 1,
        Mercedes = 2,
        Audi = 3
    }

    public enum Model
    {
        BmwM3 = 1,
        BmwM4 = 2,
        BmwM5 = 3,
        MercedesCla = 4,
        MercedesClk = 5,
        MercedesCls = 6,
        AudiA3 = 7,
        AudiA4 = 8,
        AudiA5 = 9
    }

    public enum Location
    {
        OsjeckoBaranjska = 1,
        VukovarskoSrijemska = 2,
        BrodskoPosavska = 3
    }

    public enum Engine
    {
        Diesel = 1,
        Petrol = 2,
        Electric = 3,
        Gas = 4
    }

    public enum Condition
    {
        Test = 1,
        Used = 2,
        New = 3
    }
}
