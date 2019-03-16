using AutoMapper;
using Newskalo.Common.Parameters;
using Newskalo.Service.Common.EntityCommon;
using Newskalo.Service.DAL;
using Newskalo.Services.Common.ServicesCommon;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Service.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly NewskaloDbContext _context;

        public CategoryServices(NewskaloDbContext context)
        {
            _context = context;
        }

        public void CreateCategory(ICategory category)
        {
            _context.Categories.Add(Mapper.Map<Category>(category));
        }

        public void DeleteCategory(ICategory category)
        {
            _context.Categories.Remove(_context.Categories.Find(category.Id));
        }

        public ICategory FindCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public IPagedList<ICategory> GetCategoriesPagedList(ISortParameters sortParameters, IFilterParameters filterParameters, IPageParameters pageParameters)
        {
            var categoryPagedList = _context.Categories.AsEnumerable();

            switch (sortParameters.Sort)
            {
                case "Title":
                    categoryPagedList = categoryPagedList.OrderBy(x => x.CategoryTitle);
                    break;
                case "Desc":
                    categoryPagedList = categoryPagedList.OrderBy(x => x.CategoryDescription);
                    break;
                default:
                    categoryPagedList = categoryPagedList.OrderBy(x => x.Id);
                    break;
            }

            if (string.IsNullOrEmpty(filterParameters.Search) == false)
            {
                categoryPagedList = categoryPagedList.Where(x => x.CategoryTitle.ToUpper().Contains(filterParameters.Search.ToUpper()));
            }

            if (sortParameters.Direction == "Descending")
            {
                categoryPagedList = categoryPagedList.Reverse();
            }

            return categoryPagedList.ToPagedList(pageParameters.Page, pageParameters.PageSize);
        }

        public void UpdateCategory(ICategory category)
        {
            _context.Entry(category).State = EntityState.Modified;
        }
    }
}
