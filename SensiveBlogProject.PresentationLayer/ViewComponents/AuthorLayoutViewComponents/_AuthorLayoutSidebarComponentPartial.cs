﻿using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.AuthorLayoutViewComponents
{
    public class _AuthorLayoutSidebarComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}