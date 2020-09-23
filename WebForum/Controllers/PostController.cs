using System.Collections.Generic;
using System.Linq;
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
        public PostController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);
            var replies = BuildPostReplies(post.Replies);
            var model = new PostIndexModel
            {
                Id = post.Id,
                Title = post.Title,
                Created = post.dateTime,
                AuthorId = post.User.Id,
                AuthorImageUrl = post.User.ProfileImageUrl,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                PostContent = post.Content,
                Replies = replies
            };
            return View(model);
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
                DateTime = reply.Created
            });
        }
    }
}
