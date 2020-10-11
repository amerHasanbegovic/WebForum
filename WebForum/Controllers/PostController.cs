using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebForum.Data;
using WebForum.Data.Models;
using WebForum.Models.Post;
using WebForum.Models.Reply;

namespace WebForum.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;
        private readonly IForum _forumService;
        private readonly IApplicationUser _userService;
        private static UserManager<ApplicationUser> _userManager;
        public PostController(IPost postService, IForum forumService,
            UserManager<ApplicationUser> userManager, IApplicationUser userService)
        {
            _postService = postService;
            _forumService = forumService;
            _userManager = userManager;
            _userService = userService;
        }

        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);
            var replies = BuildPostReplies(post.Replies);
            var model = new PostIndexModel
            {
                Id = post.Id,
                Title = post.Title,
                Created = post.Created,
                AuthorId = post.User.Id,
                AuthorImageUrl = post.User.ProfileImageUrl,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                PostContent = post.Content,
                Replies = replies,
                ForumId = post.Forum.Id,
                ForumName = post.Forum.Title,
                IsAuthorAdmin = IsAuthorAdmin(post.User)
            };
            return View(model);
        }

        private bool IsAuthorAdmin(ApplicationUser user)
        {
            return _userManager.GetRolesAsync(user).Result.Contains("Admin");
        }

        [Authorize]
        public IActionResult Create(int id)
        {
            var forum = _forumService.GetById(id);
            var model = new NewPostModel
            {
                ForumId = forum.Id,
                ForumName = forum.Title,
                ForumImageUrl = forum.ImageUrl,
                AuthorName = User.Identity.Name
            };
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Remove(int id)
        {
            var post = _postService.GetById(id);
            var forum = _forumService.GetById(post.Forum.Id);
            await _postService.Delete(id);
            return RedirectToAction("Topic", "Forum", new { id = forum.Id });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPost(NewPostModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var post = BuildPost(model, user);

            await _postService.Add(post); //block the thread until task is complete
            await _userService.UpdateUserRating(userId, typeof(Post));
            return RedirectToAction("Index", "Post", new { id = post.Id });
        }

        private Post BuildPost(NewPostModel model, ApplicationUser user)
        {
            var forum = _forumService.GetById(model.ForumId);
            return new Post
            {
                Title = model.Title,
                Content = model.Content,
                Created = DateTime.Now,
                User = user,
                Forum = forum
            };
        }

        private IEnumerable<PostReplyModel> BuildPostReplies(IEnumerable<PostReply> replies)
        {
            return replies.Select(reply => new PostReplyModel
            {
                Id = reply.Id,
                AuthorId = reply.User.Id,
                AuthorImageUrl = reply.User.ProfileImageUrl,
                AuthorName = reply.User.UserName,
                AuthorRating = reply.User.Rating,
                ReplyContent = reply.Content,
                Created = reply.Created,
                IsAuthorAdmin = IsAuthorAdmin(reply.User)
            });
        }
    }
}
