using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebForum.Data;
using WebForum.Data.Models;
using WebForum.Models.Reply;

namespace WebForum.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IPost _postService;
        private readonly UserManager<ApplicationUser> _userManager;
        public ReplyController(IPost postService, UserManager<ApplicationUser> userManager)
        {
            _postService = postService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Create(int id)
        {
            var post = _postService.GetById(id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var model = new PostReplyModel
            {
                PostContent = post.Content,
                PostId = post.Id,
                PostTitle = post.Title,

                AuthorId = user.Id,
                AuthorImageUrl = user.ProfileImageUrl,
                AuthorName = user.UserName,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("Admin"),

                ForumId = post.Forum.Id,
                ForumImageUrl = post.Forum.ImageUrl,
                ForumName = post.Forum.Title,

                Created = DateTime.Now
            };
            return View(model);
        }
    }
}
