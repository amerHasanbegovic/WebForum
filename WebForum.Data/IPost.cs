﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebForum.Data.Models;

namespace WebForum.Data
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        //Task AddReply(PostReply reply);
    }
}