using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebForum.Data.Models;

namespace WebForum.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();
        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(Forum forumId, string newTitle);
        Task UpdateForumDescription(Forum forumId, string newDescription);
        Task SetForumImage(int forumId, Uri uri);
    }
}
