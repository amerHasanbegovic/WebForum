﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebForum.Data;
using WebForum.Data.Models;

namespace WebForum.Service
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
        }

        public async Task AddReply(PostReply reply)
        {
            _context.PostReplies.Add(reply);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var post = GetById(id);
            var postReplies = post.Replies;

            if (postReplies != null || postReplies.Count() > 0)
                foreach (var reply in postReplies)
                    _context.PostReplies.Remove(reply);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }
        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.Include(post => post.User)
                .Include(post => post.Replies).ThenInclude(reply => reply.User)
                .Include(post => post.Forum);
        }

        public Post GetById(int id)
        {
            return _context.Posts.Where(post => post.Id == id)
                .Include(post => post.User)
                .Include(post => post.Replies).ThenInclude(reply => reply.User)
                .Include(post => post.Forum).First();
        }

        public IEnumerable<Post> GetFilteredPosts(Forum forum, string searchQuery)
        {
            return string.IsNullOrEmpty(searchQuery) ? forum.Posts : 
                forum.Posts.Where(post => post.Title.ToLower()
                .Contains(searchQuery.ToLower()) || post.Content.ToLower().Contains(searchQuery.ToLower()));
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            return GetAll().Where(post => post.Title.ToLower()
            .Contains(searchQuery.ToLower()) || post.Content.ToLower().Contains(searchQuery.ToLower()));
        }

        public IEnumerable<Post> GetLatestPosts(int v)
        {
            return GetAll().OrderByDescending(post => post.Created).Take(v);
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return _context.Forums.Where(forum => forum.Id == id).First().Posts;
        }

        public async Task RemoveReply(int postId, int replyId)
        {
            var post = GetById(postId);
            var reply = post.Replies.Where(reply => reply.Id == replyId).FirstOrDefault();
            if (reply != null)
                _context.PostReplies.Remove(reply);
            await _context.SaveChangesAsync();
        }
    }
}
