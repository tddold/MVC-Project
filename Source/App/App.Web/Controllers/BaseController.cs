﻿namespace App.Web.Controllers
{
    using System.Web.Mvc;
    using AutoMapper;
    using Infrastructure.Mapping;
    using Services.Web.Contracts;
    public class BaseController : Controller
    {
        public ICacheService Cache { get; set; }

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}