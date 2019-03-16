using AutoMapper;
using Newskalo.MVC.ViewModels;
using Newskalo.Service.Common.EntityCommon;
using Newskalo.Service.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Newskalo.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        IUnitOfWork _unitOfWork;

        public CategoriesController()
        {

        }

        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryTitle,CategoryDescription,CategoryImage")] CategoryViewModel category, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string path = Path.Combine(Server.MapPath("~/CategoryImages"), Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    category.CategoryImage = "~/CategoryImages/" + Path.GetFileName(file.FileName);
                }
                _unitOfWork.Categories.CreateCategory(Mapper.Map<Category>(category));
                _unitOfWork.Complete();
                RedirectToAction("Index", "Home");
            }

            return View(category);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                var category = _unitOfWork.Categories.FindCategoryById((int)id);
                if (category == null)
                {
                    return HttpNotFound();
                }
                return View(Mapper.Map<CategoryViewModel>(category));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, CategoryTitle, CategoryDescription, CategoryImage")] CategoryViewModel category, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string path = Path.Combine(Server.MapPath("~/CategoryImages"), Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    category.CategoryImage = "~/CategoryImages/" + Path.GetFileName(file.FileName);
                }
                _unitOfWork.Categories.UpdateCategory(Mapper.Map<Category>(category));
                _unitOfWork.Complete();
                RedirectToAction("Index", "Home");
            }

            return View(category);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                var category = _unitOfWork.Categories.FindCategoryById((int)id);
                if (category == null)
                {
                    return HttpNotFound();
                }
                return View(Mapper.Map<CategoryViewModel>(category));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CategoryViewModel category)
        {
            _unitOfWork.Categories.DeleteCategory(Mapper.Map<Category>(category));
            _unitOfWork.Complete();
            return RedirectToAction("Index", "Home");
        }
    }
}