using AutoMapper;
using Newskalo.MVC.ViewModels;
using Newskalo.Service.Common.EntityCommon;
using Newskalo.Service.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Newskalo.MVC.App_Start
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Item, ItemViewModel>().ReverseMap();
            CreateMap<ICategory, Category>().ReverseMap();
            CreateMap<IItem, Item>().ReverseMap();
        }
    }
}