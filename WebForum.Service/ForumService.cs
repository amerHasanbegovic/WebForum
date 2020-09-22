using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebForum.Data;
using WebForum.Data.Models;

namespace WebForum.Service
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;
        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
