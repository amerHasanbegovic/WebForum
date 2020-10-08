using Microsoft.EntityFrameworkCore;
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
            var forum = _context.Forums.Where(f => f.Id == id)
                .Include(p => p.Posts).ThenInclude(f => f.User)
                .Include(p => p.Posts).ThenInclude(p => p.Replies).ThenInclude(f => f.User)
                .First();
            return forum;
        }

        public async Task SetForumImage(int forumId, Uri uri)
        {
            var forum = GetById(forumId);
            forum.ImageUrl = uri.ToString();
            _context.Update(forum);
            await _context.SaveChangesAsync();
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
