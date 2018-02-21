﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeCMSCore.Modules.Admin.Controllers
{
    [Authorize(AuthenticationSchemes = "AwesomeCMSCookie")]
    public class PortalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}