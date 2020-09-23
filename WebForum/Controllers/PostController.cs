using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebForum.Data;

namespace WebForum.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;
        public PostController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
