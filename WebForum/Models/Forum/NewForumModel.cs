﻿using Microsoft.AspNetCore.Http;
namespace WebForum.Models.Forum
{
    public class NewForumModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageUpload { get; set; }
    }
}
