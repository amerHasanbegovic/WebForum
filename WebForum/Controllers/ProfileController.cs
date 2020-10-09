using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebForum.Data;
using WebForum.Data.Models;
using WebForum.Models.Profile;

namespace WebForum.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IUpload _uploadService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProfileController(UserManager<ApplicationUser> userManager,
            IApplicationUser userService, IUpload uploadService,
            IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _userService = userService;
            _uploadService = uploadService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Detail(string id)
        {
            var user = _userService.GetById(id);
            var userRoles = _userManager.GetRolesAsync(user).Result;
            var model = new ProfileModel()
            {
                UserId = user.Id,
                Email = user.Email,
                Username = user.UserName,
                UserRating = user.Rating,
                MemberSince = user.MemberSince,
                ProfileImageUrl = user.ProfileImageUrl,
                IsAdmin = userRoles.Contains("Admin")
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadProfileImage(IFormFile file)
        {
            var userId = _userManager.GetUserId(User);
            if (file != null)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string extension = Path.GetExtension(file.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;

                string path = Path.Combine(wwwRootPath + "/images/user/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                await _userService.SetProfileImage(userId, new Uri("/images/user/" + fileName, UriKind.Relative));
            }
            return RedirectToAction("Detail", "Profile", new { id = userId });
        }
        public IActionResult Index()
        {
            var profiles = _userService.GetAll().OrderByDescending(u => u.Rating)
                .Select(user => new ProfileModel
                {
                    Email = user.Email,
                    Username = user.UserName,
                    ProfileImageUrl = user.ProfileImageUrl,
                    UserRating = user.Rating,
                    MemberSince = user.MemberSince
                });
            var model = new ProfileListingModel
            {
                Profiles = profiles
            };
            return View(model);
        }
    }
}
