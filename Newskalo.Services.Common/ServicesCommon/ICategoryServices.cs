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
    public interface ICategoryServices
    {
        void CreateCategory(ICategory category);
        ICategory FindCategoryById(int id);
        IPagedList<ICategory> GetCategoriesPagedList(ISortParameters sortParameters, IFilterParameters filterParameters, IPageParameters pageParameters);
        void UpdateCategory(ICategory category);
        void DeleteCategory(ICategory category);
        
    }
}
