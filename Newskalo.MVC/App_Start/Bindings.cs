using Newskalo.Service.DAL;
using Newskalo.Service.Services;
using Newskalo.Services.Common.ServicesCommon;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Newskalo.MVC.App_Start
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryServices>().To<CategoryServices>();
            Bind<IItemServices>().To<ItemServices>();
        }
    }
}