using Newskalo.Common.Parameters;
using Newskalo.Service.Common.EntityCommon;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Services.Common.ServicesCommon
{
    public interface IItemServices
    {
        void CreateItem (IItem item);
        IItem FindItemById(int id);
        IPagedList<IItem> GetItemsPagedList(ISortParameters sortParameters, IFilterParameters filterParameters, IPageParameters pageParameters);
        void UpdateItem(IItem item);
        void DeleteItem(IItem item);
    }
}
