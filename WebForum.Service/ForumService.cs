﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebForum.Data;
using WebForum.Data.Models;

namespace WebForum.Service
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;

        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Forum forum)
        {
            _context.Forums.Add(forum);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int forumId)
        {
            var forum = GetById(forumId);
            var posts = forum.Posts;
            var postReplies = (from post in posts
                               from reply in post.Replies
                               select reply).ToList();

            if (postReplies != null || postReplies.Count() > 0)
                foreach (var reply in postReplies)
                    _context.PostReplies.Remove(reply);

            if (posts != null || posts.Count() > 0)
                foreach (var post in posts)
                    _context.Posts.Remove(post);

            _context.Forums.Remove(forum);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _context.Forums.Include(forum => forum.Posts);
        }

        public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            var forum = _context.Forums.Where(f => f.Id == id)
                .Include(p => p.Posts).ThenInclude(f => f.User)
                .Include(p => p.Posts).ThenInclude(p => p.Replies).ThenInclude(f => f.User)
                .First();
            return forum;
        }

        public Task UpdateForumDescription(Forum forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(Forum forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
