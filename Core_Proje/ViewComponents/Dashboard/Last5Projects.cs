﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
