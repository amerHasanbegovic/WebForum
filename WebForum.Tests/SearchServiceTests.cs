using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using WebForum.Data;
using WebForum.Data.Models;
using WebForum.Service;

namespace WebForum.Tests
{
    [TestFixture]
    public class Post_Service_Should
    {
        [TestCase("biscuit", 3)]
        [TestCase("TeA", 1)]
        [TestCase("Water", 0)]
        public void Return_Filtered_Resulsts_Corresponding_To_Query(string query, int expected)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;

            //arrange
            using (var ctx = new ApplicationDbContext(options))
            {
                ctx.Forums.Add(new Forum
                {
                    Id = 13
                });

                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = 10,
                    Title = "First Post",
                    Content = "Biscuit"
                });
                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = -26,
                    Title = "Biscuit",
                    Content = "Some content"
                });
                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = 1512,
                    Title = "Tea",
                    Content = "Biscuit"
                });

                ctx.SaveChanges();
            }


            //act
            using (var ctx2 = new ApplicationDbContext(options))
            {
                var postService = new PostService(ctx2);
                var result = postService.GetFilteredPosts(query);
                var postCount = result.ToList().Count();

                //assert
                Assert.AreEqual(expected, postCount);
            }


        }
    }
}
