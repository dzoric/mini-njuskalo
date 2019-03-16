using AutoMapper;
using Newskalo.Common.Parameters;
using Newskalo.Common.ParametersCommon;
using Newskalo.MVC.ViewModels;
using Newskalo.Service.Common.EntityCommon;
using Newskalo.Service.DAL;
using Newskalo.Services.Common.ServicesCommon;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Newskalo.MVC.Controllers
{
    public class HomeController : Controller
    {
        IUnitOfWork _unitOfWork;

        public HomeController()
        {

        }

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index(string sort, string direction, string search, int? page)
        {
            ISortParameters sortParameters = new SortParameters { Direction = direction, Sort = sort };
            IFilterParameters filterParameters = new FilterParameters { Search = search };
            IPageParameters pageParameters = new PageParameters { Page = page??1, PageSize = 2 };

            var categoriesList = _unitOfWork.Categories.GetCategoriesPagedList(sortParameters, filterParameters, pageParameters);

            var categoriesViewModelList = Mapper.Map<IEnumerable<CategoryViewModel>>(categoriesList);

            ViewBag.search = search;
            ViewBag.sort = sort;
            ViewBag.direction = direction;

            return View(new StaticPagedList<CategoryViewModel>(categoriesViewModelList, categoriesList.GetMetaData()));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}