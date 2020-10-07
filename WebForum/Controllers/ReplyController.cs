﻿using Microsoft.AspNetCore.Identity;
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
        private readonly IForum _forumService;
        public ReplyController(IPost postService, UserManager<ApplicationUser> userManager, IForum forumService)
        {
            _postService = postService;
            _userManager = userManager;
            _forumService = forumService;
        }

        public async Task<IActionResult> Create(int id)
        {
            var post = _postService.GetById(id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var forum = _forumService.GetById(post.Forum.Id);

            var model = new PostReplyModel
            {
                PostContent = post.Content,
                PostId = post.Id,
                PostTitle = post.Title,

                AuthorId = user.Id,
                AuthorImageUrl = user.ProfileImageUrl,
                AuthorName = User.Identity.Name,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("Admin"),

                ForumId = forum.Id,
                ForumImageUrl = forum.ImageUrl,
                ForumName = forum.Title,

                Created = DateTime.Now
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReply(PostReplyModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            var reply = BuildReply(model, user);
            await _postService.AddReply(reply);
            return RedirectToAction("Index", "Post", new { id = model.PostId });
        }

        private PostReply BuildReply(PostReplyModel model, ApplicationUser user)
        {
            var post = _postService.GetById(model.PostId);
            return new PostReply
            {
                Post = post,
                Content = model.ReplyContent,
                Created = DateTime.Now,
                User = user
            };
        }
    }
}