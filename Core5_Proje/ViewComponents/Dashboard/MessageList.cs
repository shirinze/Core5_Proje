﻿using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
