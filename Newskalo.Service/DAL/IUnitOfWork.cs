using Newskalo.Service.Services;
using Newskalo.Services.Common.ServicesCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Service.DAL
{
    public interface IUnitOfWork
    {
        ICategoryServices Categories { get; set; }
        IItemServices Items { get; set; }

        void Complete();

    }
}
