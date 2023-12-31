﻿using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {

        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Duzenleme";
            ViewBag.v2 = "Hakkimda";
            ViewBag.v3 = "Hakkimda Sayfasi ";
            var values = aboutManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
