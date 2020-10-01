using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebForum.Data;
using WebForum.Data.Models;
using WebForum.Models.Forum;
using WebForum.Models.Post;
using WebForum.Models.Search;

namespace WebForum.Controllers
{
    public class SearchController : Controller
    {
        private readonly IPost _postService;

        public SearchController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Results(string searchQuery)
        {
            var posts = _postService.GetFilteredPosts(searchQuery);
            var areNoResults = (!string.IsNullOrEmpty(searchQuery) && !posts.Any());
            var postListings = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                DatePosted = post.Created.ToString(),
                Forum = BuildForumListing(post),
                RepliesCount = post.Replies.Count(),
                Title = post.Title
            });

            var model = new SearchResultModel
            {
                Posts = postListings,
                SearchQuery = searchQuery,
                EmptySearchResults = areNoResults
            };
            return View(model);
        }

        private ForumListingModel BuildForumListing(Post post)
        {
            return new ForumListingModel
            {
                Id = post.Forum.Id,
                Title = post.Forum.Title,
                Description = post.Forum.Description,
                ImageUrl = post.Forum.ImageUrl
            };
        }

        [HttpPost]
        public IActionResult Search(string searchQuery)
        {
            return RedirectToAction("Results", new { searchQuery });
        }
    }
}
