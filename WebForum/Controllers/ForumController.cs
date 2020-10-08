using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebForum.Data;
using WebForum.Data.Models;
using WebForum.Models.Forum;
using WebForum.Models.Post;

namespace WebForum.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ForumController(IForum forumService, IPost postService, IWebHostEnvironment webHostEnvironment)
        {
            _forumService = forumService;
            _postService = postService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel
                {
                    Id = forum.Id,
                    Title = forum.Title,
                    Description = forum.Description,
                    ImageUrl = forum.ImageUrl
                });

            var model = new ForumIndexModel
            {
                ForumList = forums
            };
            return View(model);
        }
        public IActionResult Topic(int id, string searchQuery)
        {
            var forum = _forumService.GetById(id);
            var posts = new List<Post>();
            posts = _postService.GetFilteredPosts(forum, searchQuery).ToList();

            var postListings = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                Forum = BuildForumListing(post),
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                Title = post.Title,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count()
            });

            var model = new ForumTopicModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Search(int id, string searchQuery)
        {
            return RedirectToAction("Topic", new { id, searchQuery });
        }

        private ForumListingModel BuildForumListing(Post post)
        {
            var forum = post.Forum;
            return BuildForumListing(forum);
        }
        private ForumListingModel BuildForumListing(Forum forum)
        {
            return new ForumListingModel
            {
                Id = forum.Id,
                Title = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl
            };
        }
        public IActionResult Create()
        {
            var model = new NewForumModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewForum(NewForumModel model)
        {
            var ImageUri = "/images/default.png";
            if (model.ImageUpload != null)
                ImageUri = GetImageUri(model.ImageUpload);
            var forum = new Forum
            {
                Title = model.Title,
                Description = model.Description,
                Created = DateTime.Now,
                ImageUrl = "/images/" + ImageUri
            };
            await _forumService.Create(forum);
            return RedirectToAction("Index", "Forum");
        }

        private string GetImageUri(IFormFile file)
        {
            var fileName = "";
            if (file != null)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string extension = Path.GetExtension(file.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;

                string path = Path.Combine(wwwRootPath + "/images/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyToAsync(fileStream);
                }
            }
            return fileName;
        }
    }
}
