using Newskalo.Service.Common.EntityCommon;
using Newskalo.Service.Services;
using Newskalo.Services.Common.ServicesCommon;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Newskalo.Service.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NewskaloDbContext _context;
        public ICategoryServices Categories { get; set; }
        public IItemServices Items { get; set; }

        public UnitOfWork(NewskaloDbContext context)
        {
            _context = context;
            Categories = new CategoryServices(context);
            Items = new ItemServices(context);

            //var kernel = new StandardKernel();
            //kernel.Load(Assembly.GetExecutingAssembly());
            //Categories = kernel.Get<ICategoryServices>();
            //Items = kernel.Get<IItemServices>();
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
