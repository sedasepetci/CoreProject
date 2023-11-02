﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoreProje1.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
      public IViewComponentResult Invoke()
        {
            var values=serviceManager.TGetList();
            return View(values);
        }
    }
}
