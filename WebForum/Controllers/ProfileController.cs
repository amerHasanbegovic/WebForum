﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebForum.Data;
using WebForum.Data.Models;

namespace WebForum.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IUpload _uploadService;
        public ProfileController(UserManager<ApplicationUser> userManager, IApplicationUser userService, IUpload uploadService)
        {
            _userManager = userManager;
            _userService = userService;
            _uploadService = uploadService;
        }

        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}
