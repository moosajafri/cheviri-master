﻿using Microsoft.AspNetCore.Mvc;

using Cheviri.Client.Web.Helpers;
using Cheviri.Client.Web.Models;
using Cheviri.Common.Helpers;

namespace Cheviri.Client.Web.Controllers
{
    public class ProjectController : BaseController
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detail(string id)
        {
            if (id.IsNotUid())
            {
                return RedirectToAccessDenied();
            }

            return View();
        }

        [HttpGet]
        public JsonResult Items()
        {
            return Json(true);
        }
    }
}
