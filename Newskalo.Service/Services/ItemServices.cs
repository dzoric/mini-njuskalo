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
    public class ItemServices : IItemServices
    {
        private readonly NewskaloDbContext _context;

        public ItemServices(NewskaloDbContext context)
        {
            _context = context;
        }

        public void CreateItem(IItem item)
        {
            _context.Items.Add(Mapper.Map<Item>(item));
        }

        public void DeleteItem(IItem item)
        {
            _context.Items.Remove(_context.Items.Find(item.Id));
        }

        public IItem FindItemById(int id)
        {
            return _context.Items.Find(id);
        }

        public IPagedList<IItem> GetItemsPagedList(ISortParameters sortParameters, IFilterParameters filterParameters, IPageParameters pageParameters)
        {
            var itemPagedList = _context.Items.AsEnumerable();

            switch (sortParameters.Sort)
            {
                case "Make":
                    itemPagedList = itemPagedList.OrderBy(x => x.Make);
                    break;
                case "Model":
                    itemPagedList = itemPagedList.OrderBy(x => x.Model);
                    break;
                case "PriceAsc":
                    itemPagedList = itemPagedList.OrderBy(x => x.Price);
                    break;
                case "PriceDesc":
                    itemPagedList = itemPagedList.OrderByDescending(x => x.Price);
                    break;
                default:
                    itemPagedList = itemPagedList.OrderBy(x => x.Id);
                    break;
            }

            if (string.IsNullOrEmpty(filterParameters.Search) == false)
            {
                itemPagedList = itemPagedList.Where(x => x.Description.ToUpper().Contains(filterParameters.Search.ToUpper()));
            }

            if (sortParameters.Direction == "Descending")
            {
                itemPagedList = itemPagedList.Reverse();
            }

            return itemPagedList.ToPagedList(pageParameters.Page, pageParameters.PageSize);
        }

        public void UpdateItem(IItem item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
